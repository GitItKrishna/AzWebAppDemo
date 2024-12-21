**Az Web App Demo .**

1. Run and build the project and make sure it is running on your local machine.
2. Create a new Web App on Azure Portal.
   ![img.png](SampleAzWebApp/Images/img.png)
   ```
   Choose Subscription , Resource Group , App Name (say MyAzDemoApp), Runtime Stack (say .net 8) , Region (say Central US) , Windows Plan , Sku and click on Review + Create.
   ```
3. Navigate to Monitor + Secure and click no for Enable Application Insights.
   ![img.png](SampleAzWebApp/Images/img_1.png)
4. navigate to Review + Create and click on Create.
   ![img.png](SampleAzWebApp/Images/img_2.png)
5. Once the deployment is successful, navigate to the resource and click on the URL to see the deployed web app.(say : myazdemoapp-dkajacbtbshyhwfe.centralus-01.azurewebsites.net)
   ![img.png](SampleAzWebApp/Images/img_3.png)
6. You can see the sample web app running on Azure. (at myazdemoapp-dkajacbtbshyhwfe.centralus-01.azurewebsites.net)
   ![img.png](SampleAzWebApp/Images/img_4.png)
7. Now, let's deploy our local web app to Azure Web App.
8. Navigate to the project folder and open the terminal.
9. Run the below command to publish the project to a folder named Publish.
   ```
    dotnet publish -c Release -o ./bin/Publish
   ```
10. You can see the published files in the bin\Publish folder.
    ![img.png](SampleAzWebApp/Images/img_5.png)
11. Now, let's deploy the published files to Azure Web App. 
    Select the Publish folder --> Tools --> Azure --> Deploy to Azure Web Apps.
    ![img.png](SampleAzWebApp/Images/img_6.png)
12. Select the Web app from the web apps and click on Run
    ![img.png](SampleAzWebApp/Images/img_7.png)
13. You should see the terminal running the deployment and once it is successful, you can see the web app running on Azure.
    ![img.png](SampleAzWebApp/Images/img_8.png)
14. Now switch to the previous url, (https://myazdemoapp-dkajacbtbshyhwfe.centralus-01.azurewebsites.net) and you can see the deployed web app running on Azure.
    ![img.png](SampleAzWebApp/Images/img_9.png)