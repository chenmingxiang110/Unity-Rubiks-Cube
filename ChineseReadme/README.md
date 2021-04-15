# Unity-Rubiks-Cube
本项目提供了一套简单的魔方模拟程序。目前已经支持三阶魔方的鼠标/键盘操控，以及入门级自动求解程序。后续将提供更流畅快速的三阶魔方求解算法，以及内置教程等功能。

<img src="../pics/screen_0.PNG" width="600">

<img src="../pics/Project-1.gif" width="600">

Mac 用户请在下载后运行以下代码，否则可能由于安全设置导致程序无法运行。（将代码中的 Path\to\app\file.app 替换为程序的路径，比如 ~/Desktop/MacBuild.app

``
  sudo chmod -R 755 Path\to\app\file.app
``

# Develop Log

[2021-04-10] Add some sound effects.

[2021-04-09] Update images of algorithms.

[2021-04-07] Implement a clumsy auto-complete algorithm based on CFOP.

[2021-04-07] Add "custom algorithm" function. Now you can type the algorithm (e.g. R U R' U') and let the cube to operate by itself.

[2021-04-03] Add opening scene.

[2021-04-02] Add "auto-start" and "auto-stop" to the timer.

[2021-03-30] Add rotation speed control module.

[2021-03-30] Add basic formula tutorials (unfinished).

[2021-03-29] Add basic formulas.

[2021-03-28] Complete interface design and keyboard control mode.
