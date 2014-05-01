cd FindsiClient.Net
copy ..\ReadMe.md ReadMe.txt
..\.nuget\nuget.exe Pack FindsiClient.Net.csproj -Prop Configuration=Release -build
cd ..