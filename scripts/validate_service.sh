#!/bin/bash
# Validate that the service is running
curl -f http://localhost:5004 || exit 1
