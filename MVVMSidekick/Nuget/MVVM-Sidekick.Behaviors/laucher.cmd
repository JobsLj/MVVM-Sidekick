set ver=0.2.2.2
xcopy lib\*.*  ..\..\packages\MVVM-Sidekick.Behaviors.%ver%\lib  /s /i /y 
BuildPublishPackage.cmd MVVM-Sidekick.Behaviors %ver%

