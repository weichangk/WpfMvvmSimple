### 简介
MVVM = Model - View - ViewModel
Model ：现实世界中对象的抽象结果（Class）
View：UI界面（.xaml）
ViewModel：联系Model和View的关键，并分离两者（Class）

### 重点
**View与ViewMode之间的绑定**
**数据绑定**
**命令绑定**

绑定流程：
 - 编写数据数据绑定基类和命令属性绑定基类
 
![contents](https://github.com/weichangk/GitHubReadmeImg/raw/master/WpfMvvmSimple/1.png)
![contents](https://github.com/weichangk/GitHubReadmeImg/raw/master/WpfMvvmSimple/2.png)

 - ViewModel继承数据绑定基类创建数据属性和命令属性
 
![contents](https://github.com/weichangk/GitHubReadmeImg/raw/master/WpfMvvmSimple/3.png)

- 在View  .xaml.cs设置元素参与数据绑定时的数据上下文对象

![contents](https://github.com/weichangk/GitHubReadmeImg/raw/master/WpfMvvmSimple/4.png)

- 在View  .xaml进行数据和命令绑定

![contents](https://github.com/weichangk/GitHubReadmeImg/raw/master/WpfMvvmSimple/5.png)


### 架构

![contents](https://github.com/weichangk/GitHubReadmeImg/raw/master/WpfMvvmSimple/6.png)

### 优势
团队方面：统一思维方式和实现方法。
架构层面：稳定，解耦。
代码层面：可读，可测，可替换。
