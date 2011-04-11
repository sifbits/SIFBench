/*
 * Copyright © 2011 Pearson Education, Inc. or its affiliate(s).  All rights reserved.
 *
 * Pearson licenses this file to you under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using org.sifassociation.swa.common;
using System.Xml;
using System.ServiceModel.Channels;

namespace org.sifassociation.swa.flowcontrol
{
    public partial class ptFlowControl
    {
      
        private PongResponse PingImplementation(PingRequest request)
        {
            runAssertions(request.SIFHeader);

             if(request.SIFHeader.SourceId== "Olympus" )
            {
                DataModelErrorType error = new DataModelErrorType();
                error.Category = InfrastructureErrorCategoryType.Item11;
                error.Code = "1";
                error.ExtendedDesc = "This server hates every 3rd Ping and will throw an error";
                error.Desc = "Generic Ping Error";
                throw new FaultException<DataModelErrorType>(error, "Olympus is the enemy of SIF");
            }

            return genericOKResponse();
        }
        private PongResponse SleepImplementation(SleepRequest request)
        {
            runAssertions(request.SIFHeader);
            return genericOKResponse();
        }
        private PongResponse WakeupImplementation(WakeupRequest request)
        {
            runAssertions(request.SIFHeader);
            return genericOKResponse();
        }

        private SIFHeaderType createHeader()
        {
            SIFHeaderType header = new SIFHeaderType();
            header.ZoneId = "foo:bar";
            header.DataModel = Statics.XMLNS_SIF_US_DATAMODEL;
            header.DataModelVersion = Statics.VERSION_US_DATAMODEL;
            header.SourceId = this.GetType().FullName;
            header.Timestamp = DateTime.Now;
            header.InfrastructureVersion = Statics.VERSION_INFRASTRUCTURE;
            return header;
        }

        private PongResponse genericOKResponse()
        {
            SIFHeaderType header = createHeader();
            StatusType status = new StatusType();
            status.Code = InfrastructureStatusCodeType.Item0;
            status.Desc = "Success";
            PongResponse resp = new PongResponse(header, status);
            return resp;
        }

          private void runAssertions(SIFHeaderType header)
        {
            OperationContext context = OperationContext.Current;
            MessageHeaders headers = context.IncomingMessageHeaders;
            UniqueId contextMsgId = headers.MessageId;
            if (contextMsgId == null)
            {
                throw new FaultException("No WS-AddressingMsgId Specified");
            }
            Console.WriteLine("Received message with ID: {0}", contextMsgId);

            String action = headers.Action;
            if (action == null)
            {
                throw new FaultException("No WS-Addressing Action specified");
            }
            Console.WriteLine("   -Action: {0}", action);

            if (!action.StartsWith("http://www.sifassociation.org/contract/FlowControl-S11/2.x/"))
            {
                throw new FaultException("Action does not start with 'http://www.sifassociation.org/contract/FlowControl/2.x/'");
            }

            if (String.IsNullOrEmpty( header.SourceId))
            {
                throw new FaultException("SourceId is null");
            }

            Console.WriteLine("   -SourceId: {0}", header.SourceId);

            if (header.InfrastructureVersion != "2.5")
            {
                throw new FaultException("Infrastructure Version is " + header.InfrastructureVersion + " instead of '2.5'");
            }

            Console.WriteLine("   -InfraVer: {0}", header.InfrastructureVersion);

            if (header.Timestamp == null)
            {
                throw new FaultException("Missing timestamp, or incorrect timestamp");
            }
            DateTime timestamp = header.Timestamp;
            TimeSpan diff = DateTime.Now - timestamp;
            if (diff.TotalDays > 30)
            {
                throw new FaultException("Timestamp: '" + timestamp + "' does not represent a recent date");
            }

            Console.WriteLine("   -Timestamp: {0}", header.Timestamp);
            if (String.IsNullOrEmpty( header.ZoneId ))
            {
                throw new FaultException("ZoneId is null");
            }
            Console.WriteLine("   -ZoneId: {0}", header.ZoneId);
        }

    }
}
