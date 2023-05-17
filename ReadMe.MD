open in vs code

press Shift + CTL + V (for reader view)

install this 

fine code covarage is a free tool to get your code coverage without the need for an enterprise licence 

https://marketplace.visualstudio.com/items?itemName=FortuneNgwenya.FineCodeCoverage2022
https://www.youtube.com/watch?v=Rae5bTE2D3o

then open the solution


run tests
![Alt text](Images/devenv_uzkuglgBSF.png)

green lines on the side show covered code
yellow is partially covered
red is uncovered
(takes a second to load up)
![Alt text](Images/devenv_60u5YdEN0K.png)

open fine code coverage page
![Alt text](Images/devenv_8sew9LKTk3.png)

should look line this
![Alt text](Images/devenv_8sew9LKTk3.png)
Prove code coverage is good

open powershell

navigate to 
./ConsoleApp1/__Tests__

install
run this > `dotnet tool install -g dotnet-stryker`
run this > `dotnet new tool-manifest`
run this > `dotnet tool install dotnet-stryker`

![Alt text](Images/WindowsTerminal_jP5rM4w6CT.png)

running
run this to run stryker > `dotnet stryker`

![Alt text](Images/WindowsTerminal_5JVZtj3kPH.png)




https://www.youtube.com/watch?v=sGwfwtkaDfk