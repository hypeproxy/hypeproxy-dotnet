#!/bin/bash
export MINOR_VERSION=$(grep -o "<Version>3.0.\(.*\)<\/Version>" ./src/HypeProxy/HypeProxy.csproj | sed 's/<Version>3.0.\(.*\)<\/Version>/\1/' | awk '{print $1+1}')
sed -i "s/<Version>3.0.\(.*\)<\/Version>/<Version>3.0.$MINOR_VERSION<\/Version>/" ./src/HypeProxy/HypeProxy.csproj
sed -i "s/<PackageVersion>3.0.\(.*\)-alpha<\/PackageVersion>/<PackageVersion>3.0.$MINOR_VERSION-alpha<\/PackageVersion>/" ./src/HypeProxy/HypeProxy.csproj
