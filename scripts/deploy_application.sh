#!/bin/bash
# Navigate to the app directory and publish the app
cd /home/ec2-user/my-web-api
dotnet publish -c Release -o /home/ec2-user/my-web-api/published
