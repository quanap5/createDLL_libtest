# createDLL_libtest

# Introduction

A Dynamic Link Library(Dll) is labrary that contain functions and codes that can be used by many clien application.
In order to use a DLL file, we have to add it as reference in which your application need to run.
Executable can be run directly but DLL file.

# Creating DLL file

Step1: Open visual Studio then  select File --> New --> Project then select the Class library

Step2: Change the default class to your desired name
I give an example with name as Calculate. This class contains the methods like addition and submission 2 integer.

Step3: Details of each methods for addtition and submission.
  
Step4: Build the solution to create the DLL in folder ../bin/debug/...
    
Using DLL file as reference in your application.
    
Step1: Create an project File --> New --> Project then select Template you want to implement
    
Step2: Design form and write the logic code
    
Step3: Add DLL using CalculateLib.dll from previous phase. Right-click on the project and then click to Add reference
    
Finish
