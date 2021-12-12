## Welcome to my GitHub Page

This is my first try to use github. Save-Datas is my first project on github.


### My XAML

Here is the first xaml file

```html
<Window x:Class="save_datas.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:save_datas"
        mc:Ignorable="d"
        Title="Save Datas" Height="850" Width="1250" WindowStartupLocation="CenterScreen" WindowState="Normal" ResizeMode="NoResize">
    <Grid>
        <Menu>
            <MenuItem Header="_File">
                <MenuItem Header="_New" />
                <MenuItem Header="_Open" />
                <MenuItem Header="_Save"/>
                <MenuItem Header="Save _as"/>
                <Separator></Separator>
                <MenuItem Header="_Exit"/>
            </MenuItem>
        </Menu>
        <RichTextBox Margin="55,28,55,177">
            <FlowDocument>
                <Paragraph>
                    <Run Text="RichTextBox"/>
                </Paragraph>
            </FlowDocument>
        </RichTextBox>
        <StackPanel Margin="55,660,55,10" Background="#FF3BF3BD">
            <Label Content="Topic for your article:" FontWeight="Bold"/>
            <CheckBox Content="Computer" Name="computerCB" Margin="15,0,1000,10"/>
            <CheckBox Content="Car" Name="carCB" Margin="15,0,1000,10"/>
            <CheckBox Content="Football" Name="footballCB" Margin="15,0,1000,10"/>
            <CheckBox Content="Music" Name="musicCB" Margin="15,0,1000,10"/>
        </StackPanel>
    </Grid>
</Window>
```

In this program are right now no functions. It is only the frontend. 12.12.2021

### Class savedatas.cs

```csharp
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace save_datas
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Savedatas SD = new Savedatas();

            SD.textboxInhalt = Convert.ToString(textbox.Document);

            SD.save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\userdaten.txt");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Savedatas SD = new Savedatas();

            SD.load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\userdaten.txt");

           
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
```
