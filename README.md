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
![在这里插入图片描述](https://img-blog.csdnimg.cn/2021010623205385.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM5ODI3NjQw,size_16,color_FFFFFF,t_70)
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210106232119828.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM5ODI3NjQw,size_16,color_FFFFFF,t_70)

 - ViewModel继承数据绑定基类创建数据属性和命令属性
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210106233542697.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM5ODI3NjQw,size_16,color_FFFFFF,t_70)
- 在View  .xaml.cs设置元素参与数据绑定时的数据上下文对象
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210106233939710.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM5ODI3NjQw,size_16,color_FFFFFF,t_70)

- 在View  .xaml进行数据和命令绑定![在这里插入图片描述](https://img-blog.csdnimg.cn/20210106234242295.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM5ODI3NjQw,size_16,color_FFFFFF,t_70)

```csharp
Command="{Binding DataContext.SelectMenuItemCommand, RelativeSource={RelativeSource Mode=FindAncestor, AncestorType={x:Type DataGrid}}}"
```
AncestorType可以指向“祖先”Windows，这句话总的理解就是Windows.DataContext.SelectMenuItemCommand，如果只有Binding SelectMenuItemCommand将不会触发命令


### 架构
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210106230924873.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3FxXzM5ODI3NjQw,size_16,color_FFFFFF,t_70)

### 优势
团队方面：统一思维方式和实现方法。
架构层面：稳定，解耦。
代码层面：可读，可测，可替换。


[GitHub链接，有帮助的话给个Star哦](https://github.com/weichangk/WpfMvvmSimple)
