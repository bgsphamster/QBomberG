# QBomber
## 项目介绍
这是一个基于Python和C# .NET的QQ轰炸器（由于特殊的原理，理论上可以用于任何包括但不限于QQ的IM软件）

Python部分使用PyAutoGui作为主要实现方法，直接模拟键鼠操作，不同于传统Win32API的实现

由于使用Winform框架，暂不支持Windows以外平台

## 安装方法
### 方法一：（推荐给普通用户）直接下载
**建议使用一些Github加速工具，不然速度感人**
https://github.com/bgsphamster/QBomberG/releases 即为下载地址，点击Assets，有个QBomberWithGUI.zip，下载下来解压双击QBomberG.exe就可以用，注意里面几个JSON文件千万别删改，否则后果自负

### 方法二：编译安装
**需要安装Visual Studio 2022和.NET桌面开发的组件，否则无法编译！**
第一步：下载软件源码
```bash
git clone https://github.com/bgsphamster/QBomberG
```
进入克隆后代码的目录，找到QBomber.sln，以Visual Studio打开之，即可选择一个模式编译。

## 使用方法
1. 首先在每个输入框中输入信息
2. 点击“开始轰炸”
3. 在“准备时间”栏所填写的秒数之内快速用鼠标定位到QQ需要轰炸的聊天窗口输入框内
4. 不要使用键盘鼠标，耐心等待结束
