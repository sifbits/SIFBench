                            READDME
                
             ************************************   
             SIF Web Service Application Test Kit
             *************************************


Copyright © 2011 Pearson Education, Inc. or its affiliate(s).  
All rights reserved.
                   
Pearson licenses this software to you under the Apache License, Version 2.0
(the "License"); you may not use this file except in compliance with
the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.




OVERVIEW

This sample is intended for use to test the new SOAP transport capability of
the SIF 2.5 Specification. It was developed in cooperation with the SIF Web 
Services Task Force. The intent of this software is to run the series of tests
that are documented in the included document entitled "SIF Web Services Transport 
2 5 Test Plan and Results1.1.doc"




DISTRIBUTION OVERVIEW

 ReadMe.txt - This file
 SIF25WebApplication.sln - A Visual Studio 2008 project
 /bin - The binary executables for running the SIF 25 Web Application Server
 /docs - Licenses and documents
 /tests - Unit tests for testing the server
 /src - The application and test source code




STATUS AND KNOWN ISSUES

This source code was rapidly assembled and doesn't represent best practices or
necessarily the best design paradigms. 

Known Issues include:
 - Portions of the auto-generated code from the WSDL is duplicated
 - Little attempt was made to reuse code between class files




MODIFYING THE DEPLOYMENT URLS

The deployment URLS can be modified, and proxy settings can be specified by
modifying the standard .Net App.config files in both the /bin and /test
directories. For example, a proxy server can be interposed between the client
and server so that messages can be traced by modifying the client App.config
and specifying the 




RUNNING THE SAMPLE SERVER

Running the sample server requires the Microsoft .Net 3.5 or greater to be 
installed on the test system.

Open Windows Command Prompt and navigate to the /bin folder.
Run "SIF25Svchost.exe"




RUNNING THE SAMPLE UNIT TESTS

Running the sample tests requires Microsoft Visual Studio 2008 or greater 
to be installed on the test system.


** Note!!!
Note that the Unit Tests are configured by default to use a local proxy server hosted
at port 8080 and connect to a host with the name "sifmonster". If you wish to run these
tests, you need to change the URL to reflect the host where the service is running. If
you are not running a local proxy server, comment out the proxy server setting.

Open the Microsoft Visual Studio 2008 Command Prompt
and navigate to the /tests folder. run the following:

mstest /testcontainer:org.sifassociation.swa.testing.dll