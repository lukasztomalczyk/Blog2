#!/bin/bash
dotnet build
dotnet publish -c Release -o ./bin/Docker
docker build -t my_blog:latest .
docker-compose build
docker-compose up