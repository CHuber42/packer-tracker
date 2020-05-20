## _Packer Tracker_

### _Created by Tyler Bates, Christopher Huber & Nitun Datta_

## _Description_

Packer Tracker is an interactive program allowing you you plan your packing list for an upcoming trip. The User fills out a form with inputs for the item name, whether it needs to be purchased, the items price, whether it's been packed or not and the items weight. With this information you can check to see if your pack is within your budget and weight limitations for travel.

## _Setup_

- Clone this projects repository into your local directory following <a href="https://www.linode.com/docs/development/version-control/how-to-install-git-and-clone-a-github-repository/">these</a> instructions.<br>
- Install .NET Core using <a href="https://docs.microsoft.com/en-us/dotnet/core/install/runtime?pivots=os-windows">this</a> link.<br>
- In your terminal, navigate to the "PackerTracker" directory within the project folder.<br>
- From within this directory, enter the following into your terminal:<br>
```
$ dotnet run
```
If it doesn't launch automatically, click this link to launch in your browser https://locahost:5000

## _Technology Used_

## <a href="https://en.wikipedia.org/wiki/C_Sharp_%28programming_language%29">C#</a>
## <a href="https://en.wikipedia.org/wiki/.NET_Core">.NET Core</a>
## <a href="https://en.wikipedia.org/wiki/Visual_Studio_Unit_Testing_Framework">MSTest</a>

## _Specs_

|Behavior|Input|Output|
|-----|-----|-----|
|Program will dynamically add input to a list starting at index "1"|"Tent"|"Tent = List[1]"|
|Program will attatch a unique Id to each new entry added to list|"Tent", "SleepingBag"|"Tent = List[1]", "SleepingBag = List[2]"|
|Program returns value from input form|"Tent"| "Tent"|



## _Legal_

#### MIT License

### Copyright (c) 2020 Tyler Bates & Christopher Huber & Nitun Datta @ Epicodus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.