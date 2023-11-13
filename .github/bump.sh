#!/bin/bash
export MINOR_VERSION=$(grep -o "<Version>3.1.\(.*\)<\/Version>" ./src/HypeProxy/HypeProxy.csproj | sed 's/<Version>3.1.\(.*\)<\/Version>/\1/' | awk '{print $1+1}')
sed -i "s/<Version>3.1.\(.*\)<\/Version>/<Version>3.1.$MINOR_VERSION<\/Version>/" ./src/HypeProxy/HypeProxy.csproj
sed -i "s/<PackageVersion>3.1.\(.*\)-beta<\/PackageVersion>/<PackageVersion>3.1.$MINOR_VERSION-beta<\/PackageVersion>/" ./src/HypeProxy/HypeProxy.csproj
