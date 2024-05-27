#!/bin/bash
# Start the application
cd /home/ec2-user/my-web-api/published
nohup dotnet my-web-api.dll > /dev/null 2>&1 &
