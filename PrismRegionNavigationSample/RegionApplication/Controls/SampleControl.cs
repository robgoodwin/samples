using System;
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

namespace RegionApplication.Controls
{
   /// <summary>
   /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
   ///
   /// Step 1a) Using this custom control in a XAML file that exists in the current project.
   /// Add this XmlNamespace attribute to the root element of the markup file where it is 
   /// to be used:
   ///
   ///     xmlns:MyNamespace="clr-namespace:RegionApplication.Controls"
   ///
   ///
   /// Step 1b) Using this custom control in a XAML file that exists in a different project.
   /// Add this XmlNamespace attribute to the root element of the markup file where it is 
   /// to be used:
   ///
   ///     xmlns:MyNamespace="clr-namespace:RegionApplication.Controls;assembly=RegionApplication.Controls"
   ///
   /// You will also need to add a project reference from the project where the XAML file lives
   /// to this project and Rebuild to avoid compilation errors:
   ///
   ///     Right click on the target project in the Solution Explorer and
   ///     "Add Reference"->"Projects"->[Browse to and select this project]
   ///
   ///
   /// Step 2)
   /// Go ahead and use your control in the XAML file.
   ///
   ///     <MyNamespace:SampleControl/>
   ///
   /// </summary>
   public class SampleControl : Control
   {


      public Control LeftContents
      {
         get { return (Control)GetValue(LeftContentsProperty); }
         set { SetValue(LeftContentsProperty, value); }
      }

      // Using a DependencyProperty as the backing store for LeftContents.  This enables animation, styling, binding, etc...
      public static readonly DependencyProperty LeftContentsProperty =
          DependencyProperty.Register("LeftContents", typeof(Control), typeof(SampleControl), new PropertyMetadata(null));

      public Control RightContents
      {
         get { return (Control)GetValue(RightContentsProperty); }
         set { SetValue(RightContentsProperty, value); }
      }

      // Using a DependencyProperty as the backing store for RightContents.  This enables animation, styling, binding, etc...
      public static readonly DependencyProperty RightContentsProperty =
          DependencyProperty.Register("RightContents", typeof(Control), typeof(SampleControl), new PropertyMetadata(null));


      static SampleControl()
      {
         DefaultStyleKeyProperty.OverrideMetadata(typeof(SampleControl), new FrameworkPropertyMetadata(typeof(SampleControl)));
      }
   }
}
