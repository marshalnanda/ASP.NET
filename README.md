# ASP.NET
https://docs.google.com/document/d/1tdDuAEnZuY3hyWiKuVTwLmWWct3FujNqg0cb6vBdEO8/edit?usp=sharing

 Asp.Net

ASP.NET is a Web application framework developed by Microsoft to build dynamic data driven Web applications and Web services. 
1. ASP.NET is a subset of .NET framework. In simple terms a framework is a collection of classes. 
2. ASP.NET is the successor to classic ASP (Active Server Pages).

A web application is an application that is accessed by users using a web browser. Examples of web browsers include 
1. Microsoft Internet Explorer
2. Google Chrome

What are the advantages of Web applications?
1. Web Applications just need to be installed only on the web server, where as desktop applications need to be installed on every computer, where you want to access them.
2. Maintenance, support and patches are easier to provide.
3. Only a browser is required on the client machine to access a web application.
4. Accessible from anywhere, provided there is internet.
5. Cross Platform

How Web applications work.
1. Web applications work on client/server architecture
2. On the client all you need is a browser, that can understand HTML
3. On the server side, the Web application runs under Microsoft Internet Information Services (IIS)

When the client enters the URL of the web application in the browser, and submits the request. The web server which hosts the web application, receives the request. The request is then processed by the application. The application generates, the HTML and hands it over to the IIS (web server). Finally, IIS sends the generated HTML to the client, who made the initial request. The client browser will the interpret the HTML and displays the user interface. All this communication, happens over the internet using HTTP protocol. HTTP stands for Hyper Text Transfer Protocol. A protocol is a set of rules that govern how two or more items communicate.

Web Forms: WebForms has the extension of .aspx. A web form also has a code behind and designer files. Code behind files has the extension of .aspx.cs (if c# is the programming language) or .aspx.vb (if vb is the programming language). Designer files contains the extension of .aspx.designer.cs (if c# is the programming language) or .aspx.designer.vb (if visual basic is the programming language). Code behind files contain the code that user writes, where as the designer file contains the auto generated code
A Web form is associated with its code file using the @Page directive found in the Web form’s HTML.

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

Web Applications work on HTTP protocol. HTTP protocol is a stateless protocol, meaning it does not retain state between user requests.

ViewState variable Clicks to preserve the data between requests. The ViewState data, travles with every request and response between the client and the web server.
Because Web forms have very short lifetimes, ASP.NET takes special steps to preserve the data entered in the controls on a Web form. Data entered in controls is sent with each request and restored to controls in Page Init. The data in these controls is then available in the Page_Load(), Button_Click(), and many more events, that occur after Page_Init()event.

In a web application, events can occur at 3 levels
1. At the Application Level(Example: Application Start)
2. At the Page Level(Example: Page Load)
3. At the Control Level (Example: Button Click)

What is a Session, in a web application?
A session is a unique instance of the browser. A single user can have multiple sessions, by visiting your application, with multiple instances of the browser running with a different session-id on his machine.

ViewState:
1. ViewState of a webform is available only with in that webform
2. ViewState is stored on the page in a hidden field called _ViewState. Because of this, the ViewState, will be lost, if you navigate away  from the page, or if the broswer is closed.
3. ViewState is used by all asp.net controls to retain their state across postback

Session State:
1. Session state variables are available across all pages, but only for a given single session. Session variables are like single-user global data.
2. Session state variables are stored on the web server.
3. SessionState variables are cleared, when the user session times out. The default is 20 minutes. This is configurable in web.config

Application State:
1. Application State variables are available across all pages and across all sessions. Application State variables are like multi-user global data.
2. Application State variables are stored on the web server.
3. Application State variables are cleared, when the process hosting the application is restarted

some of the commonly used page level events in the life cycle of an asp.net webform.
PreInit - this event happens just before page initialization event starts.  IsPostBack, IsCallback and IsCrossPagePostBack properties are set at this stage. This event allows us to set the master page and theme of a web application dynamically. PreInit is extensively used when working with dynamic controls.

Init - Page Init, event occurs after the Init event, of all the individual controls on the webform. Use this event to read or initialize control properties. The server controls are loaded and initialized from the Web form’s view state.

InitComplete - As the name says, this event gets raised immediately after page initialization.

PreLoad - Happens just before the Page Load event.
Load - Page Load event, occurs before the load event of all the individual controls on that webform. 

Control Events - After the Page load event, the control events like button's click, dropdownlist's selected index changed events are raised.

Load Complete - This event is raised after the control events are handled.

PreRender - This event is raised just before the rendering stage of the page. 
PreRenderComplete - Raised immediately after the PreRender event.

Unload - Raised for each control and then for the page. At this stage the page is, unloaded from memory.
Error - This event occurs only if there is an unhandled exception.

Examples
protected void Page_PreInit(object sender, EventArgs e)
{ Response.Write("Page_PreInit" + "<br/>"); }

protected void Page_Init(object sender, EventArgs e)
{ Response.Write("Page_Init" + "<br/>"); }

protected void Page_InitComplete(object sender, EventArgs e)
{ Response.Write("Page_InitComplete" + "<br/>"); }

protected void Page_PreLoad(object sender, EventArgs e)
{ Response.Write("Page_PreLoad" + "<br/>"); }

protected void Page_LoadComplete(object sender, EventArgs e)
{ Response.Write("Page_LoadComplete" + "<br/>"); }

protected void Page_PreRender(object sender, EventArgs e)
{ Response.Write("Page_PreRender" + "<br/>"); }

protected void Page_PreRenderComplete(object sender, EventArgs e)
{ Response.Write("Page_PreRenderComplete" + "<br/>"); }

protected void Page_Unload(object sender, EventArgs e)
{//Response.Write("Page_Unload" + "<br/>"); }
control level events. 
ASP.NET server controls, such as TextBox, Button, and DropDownList has their own events. For example, Button has a click event. TextBox has TextChanged event, and DropDownList has SelectedIndexChanged event. We have a set of asp.net validation controls, that has validation events. The events that all these controls expose, can be broadly divided into 3 categories.

Postback events - These events submit the Web page, immediately to the server for processing. Click event of a button control is an example for PostBack event.

Cached events - These events are saved in the page’s view state to be processed when a postback event occurs. TextChanged event of TextBox control, and SelectedIndexChanged event of a DropDownList control are examples of cached events. Cached events can be converted into postback events, by setting the AutoPostBack property of the control to true.

Validation events - These events occur on the client, before the page is posted back to the server. All validation controls use these type of events.

IsPostBack in ASP.NET
IsPostBack is a Page level property, that can be used to determine whether the page is being loaded in response to a client postback, or if it is being loaded and accessed for the first time. 

ASP.NET TextBox Control
The TextBox control is used to get the input from the user of the web application.

Properties of a TextBox control

1. TextMode Propertry - SingleLine, MultiLine and Password.
When you set the TextMode to MultiLine, use Rows property to control the number of lines to display for a MultiLine TextBox.
2. Text - Use this property to set or get the Text from the TextBox.
3. MaxLength - The maximum number of chatacters that a user can enter.
4. ReadOnly - Set this property to true if you don't want the user to change the text in the TextBox.
5. ToolTip - The tooltip is displayed when the mouse is over the control.
6. Columns - Use this property to specify the width of the TextBox in characters
7. Height - Set the height
8. Width - Set the width
9. AutoPostBack - By default, the TextChanged event of a TextBox control is cached in the viewstate, and is executed when the webform is submitted thru a postback by clicking the button control. If you want to change this behaviour, and post the webform immediately when the Text is changed, set AutoPostBack to true. Setting this property to true, will convert the cached event into a postback event.


Events of TextBox:
TextChanged - This event is fired, when the text is changed.

Methods of a TextBox:
Focus - Set input focus onto the control.

ASP.NET Radio Button Control 
Radio Button control is used, when you want the user to select only one option from the available choices. For example, the gender of a person. A person can be Male or Female. He cannot be both.In short, if you want to provide the user with mutually exclusive options, then choose a Radio Button Control.

Important Properties of the Radio Button Control
Checked - This is a boolean property, that is used to check if the button is checked or not.
Text - This is string property used to get or set the text associated with the radio button control
TextAlign - right or left. On which side of the radio button the text should appear
AutoPostBack - Set this property to true, if you want the webform to be posted immediately when the checked status of the radio button changes.
Group Name - By default, the individual radio button selections, are not mutually exclusive. If you have a group of radio buttons, and if you want the selections among the group to be mutually exclusive, then use the same group name for all the radio button controls.

Events:
CheckedChanged - This event is fired when the checked status of the radio button control is changed.

ASP.NET CheckBox Control
CheckBox Control is used, when you want the user to select more than one option from the available choices. In short, if you want to provide the user with more than one option to select from, then choose a check box Control.

Important Properties of the CheckBox Control
Checked - This is a boolean property, that is used to check if the check box is checked or not.
Text - This is a string property used to get or set the text associated with the check box control
TextAlign - right or left. On which side of the check box the text should appear
AutoPostBack - Set this property to true, if you want the webform to be posted immediately when the checked status of the check box changes.

Methods:
Focus() - Just like TextBox, checkbox also supports, Focus() method. If you want to set the input focus, to a specific checkbox, Call this method for that check box control.

Events:
CheckedChanged - This event is fired when the checked status of the check button control is changed.

ASP.NET Hyperlink control
The ASP.NET Hyperlink control is used to create a link to another Web page.

Properties:
Text - The link text that will be shown to the user
Navigate URL - The URL of the page to which the user will be sent
ImageURL - The URL of the image, that will be displayed for the link. If you specify both the Text and ImageUrl, the image will be displayed instead of the text. If for some reason, the image is not unavailable, the text will be displayed.
Target - If target is not specified, the web page to which the hyperlink is linked, will be displayed in the same window. If you set the Target to _blank, the web page will be opened in a new window.

Methods:
Focus() - Call this method to Set the input focus when the page loads.

Events:
No HyperLink control specific events

ASP.NET Button, LinkButton and ImageButton Controls

The Button, LinkButton and ImageButton controls in ASP.NET are used to post a page to the server.
1. Button - The Button control is used to display a push button. Use the Text property to change the Text on the Button control.
2. LinkButton - LinkButton displays the button like a HyperLink. Use the Text property to change the LinkText.
3. ImageButton - ImageButton provides the flexibility of associating an Image with the button, using the ImageURL property.

All the 3 button controls support CommandName and CommandArgument properties.
These 3 button controls also support CuasesValidation and ValidationGroup and PostBackURL properties.

All the 3 button controls, exposes client side click event and server side click event. You can associate the javascript, that you want to run in response to the click event on the client side using OnClientClick property as shown below.

<asp:Button ID="Button1" runat="server" 
OnClientClick="alert('You are about to submit this page')" 
Text="Button" /> 
When you click this button, you will get a popup as shown below. Once you click OK, the webform will be submitted to the server for processing server side click event. 

Sometimes, we may accidentally click on a delete button, which deletes the record permanently. So, whenever, we do things like this, we want to be double sure, if the user really wants to delete the record. The javascript confirm(), function can be used for this purpose. 
<asp:Button ID="Button1" runat="server" 
OnClientClick="return confirm('Are you sure you want to delete this record?')" 
Text="Button" />

When you click the button now, the user will be shown a confirmation box, as shown below.


If you click cancel, the confirm() function returns false and the webform will not be submitted. If you click OK, the confirm() function returns true, and the webform will be posted to the server.

So, far javascript is associated, to the client click event of a button control at design time. It is also, possible, to do the same at runtime using the Button controls attribute collection as shown below.
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        Button1.Attributes.Add("onclick", "return confirm('Do you want to delete the record?');");
    }
}

Command Event of an asp.net button control

If you have multiple button controls on a webform, and if you want to programmatically determine which Button control is clicked, we can make use of Command event, along with CommandName and CommandArgument properties. Command event, makes it possible to have a single event handler method responding to the click event of multiple buttons. The command event, CommandName and CommandArgument properties are extremely useful when working with data-bound controls like Repeater, GridView, DataList.

Example- Consider the HTML below. Here we have 4 buttons. Notice that all the button controls have the same command event handler method - oncommand="CommandButton_Click". 
Also, notice the CommandName and CommandArgument properties. 
We will later use these properties, in the code behind to determine which button is clicked.

<asp:Button ID="PrintButton" runat="server" Text="Print" oncommand="CommandButton_Click" CommandName="Print"/>

<asp:Button ID="DeletButton" runat="server" Text="Delete" oncommand="CommandButton_Click" CommandName="Delete"/>

<asp:Button ID="Top10Button" runat="server" Text="Show Top 10 Employees" oncommand="CommandButton_Click" CommandName="Show" CommandArgument="Top10"/>

<asp:Button ID="Bottom10Button" runat="server" Text="Show Bottom 10 Employees" oncommand="CommandButton_Click"  CommandName="Show" CommandArgument="Bottom10"/>
        
<asp:Label ID="OutputLabel" runat="server"></asp:Label>

The CommandEventArgs object, has the CommandName and CommandArgument properties, that are used to programatically determine which button the user has clicked.

protected void CommandButton_Click(object sender, CommandEventArgs e)
{
    switch (e.CommandName)
    {
        case "Print":
            OutputLabel.Text = "You clicked Print Button";
            break;
        case "Delete":
            OutputLabel.Text = "You clicked Delete Button";
            break;
        case "Show":
            if (e.CommandArgument.ToString() == "Top10")
            {
                OutputLabel.Text = "You clicked Show Top 10 Employees Button";
            }
            else
            {
                OutputLabel.Text = "You clicked Show Bottom 10 Employees Button";
            }
            break;
        default:
            OutputLabel.Text = "We don't know which button you clicked";
            break;
    }
}

All the 3 button controls - Button, LinkButton and ImageButton, expose Command event, the CommandName and Command Argument properties. 


Dropdownlist in asp.net
If you want a specific listitem to be selected in the dropdownlist, when the page loads, then set the Selected property of the ListItem object to true.
To hide a ListItem in the DropDownList, set the Enabled property to False.

<asp:DropDownList ID="DropDownList1" runat="server">
    <asp:ListItem Value="1">Male</asp:ListItem>
    <asp:ListItem Value="1" Selected="True">Female</asp:ListItem>
</asp:DropDownList>

To add items to the DropDownList at run time using code
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        ListItem maleListItem = new ListItem("Male", "1");
        ListItem femaleListItem = new ListItem("Female", "2");

        DropDownList1.Items.Add(maleListItem);
        DropDownList1.Items.Add(femaleListItem);
    }
}

If you are adding listitem objects, to the DropDownList in the Page_Load event, make sure you do only when the page is loaded for the first time. Otherwise, every time, you post the page back, by clicking a button, the list items will be added again causing duplication.

A DropDownList is a collection of ListItem objects. Along the same lines, the following controls are also a collection of ListItem objects. So, adding items to these controls is also very similar to DropDownList.
1. CheckBoxList
2. RadioButtonList
3. BulletedList
4. ListBox



Data bind asp.net dropdownlist with data from the database (ADO.NET)


<form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <div>
        </div>
</form>
Code behind page
protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=.; database=web_forms; integrated security=SSPI");  // connection form sql server
            SqlCommand cmd = new SqlCommand("Select * from tblCity",con);
            con.Open();
            SqlDataReader rdr= cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
        }


Binding an asp.net dropdownlist with an XML file
XML file
<?xml version="1.0" encoding="utf-8" ?>
<Countries>
  <Country>
    <CountryId>101</CountryId>
    <CountryName>India</CountryName>
  </Country>
  <Country>
    <CountryId>102</CountryId>
    <CountryName>US</CountryName>
  </Country>
  <Country>
    <CountryId>103</CountryId>
    <CountryName>Australia</CountryName>
  </Country>
  <Country>
    <CountryId>104</CountryId>
    <CountryName>UK</CountryName>
  </Country>
</Countries>


Code behind page.
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        //Create a new DataSet
        DataSet DS = new DataSet();
        //Read the xml data from the XML file using ReadXml() method
        DS.ReadXml(Server.MapPath("Countries.xml"));
        DropDownList1.DataTextField = "CountryName";
        DropDownList1.DataValueField = "CountryId";
        DropDownList1.DataSource = DS;
        DropDownList1.DataBind();
        ListItem li = new ListItem("Select", "-1");
        DropDownList1.Items.Insert(0, li);
    }
}
Mapping virtual path to physical path using Server.MapPath method

Server.MapPath() method. This method returns the physical path for a given virtual path. This method can be used in several different ways, depending on the characters that we use in the virtual path.

Response.Write(". returns " + Server.MapPath(".") + "<br/>")
It returns the current physical directory of the page that you are running.

Response.Write(". returns " + Server.MapPath("..") + "<br/>")
Server.MapPath("..") returns the parent pysical directory of the page that you are running.

Response.Write("~ returns " + Server.MapPath("~") + "<br/>");
Server.MapPath("~") returns the physical path of the root directory of the application.

The number of double dots, that we use, depends on how deep we are in the folder hierarchy. To avoid confusion, if any time you want to navigate to the root directory of the application, it is better to use ~(tilde) character 
Tilde(~) symbol resolves to the root application directory, no matter how deep we are in the folder hierarchy.

Retrieving selected item text, value and index of an asp.net dropdownlist

To retrieve the Text of the Selected ListItem object as shown below.
DropDownList1.SelectedItem.Text

To retrieve the Selected item value from the DropDownList, we can use
DropDownList1.SelectedItem.Value  OR DropDownList1.SelectedValue

To get the index of the Selected ListItem object of the dropdownlist, we use SelectedIndex property as shown below.
DropDownList1.SelectedIndex

Asp.net checkboxlist control

By default, the ListItem objects are laid out in vertical direction. If you want to change the direction, use RepeatDirection property
<asp:CheckBoxList ID="checkkboxListEducation" runat="server" RepeatDirection="Horizontal">

RepeatColumns property specifies the number of columns used to lay out the items.

Set the Enabled property of the ListItem object to false, to disable the selection, in the CheckBoxList control.

SelectedIndex property of the CheckBoxList control can also be used to get the index of the selected item in the checkboxlist. But this property, returns only one selected item, and that too, the item with the lowest index. SelectedIndex property returns -1, if nothing is selected.

SelectedValue property returns the selected Item's value, but only for one selected item. If no item is selected this property returns empty string.

To retrieve the Text of the selected item, SelectedItem.Text property can be used. SelectedItem will be NULL, if nothing is selected, and hence, calling Text and Value properties may cause NullReferenceException. Hence, it is important to check for null, when using SelectedItem property of a CheckBoxList control.
if (checkboxListEducation.SelectedItem != null)
{
    Response.Write(checkboxListEducation.SelectedItem.Text);
}

Asp.net ListBox control

ListBox control. Just like DropDownList and CheckBoxList, ListBox control is also a collection of ListItem objects. Working with ListBox control is very similar to DropDownList and CheckBoxList. Adding items and binding to a datasource is exactly similar.

Properties
Rows : The number of visible rows in the Listbox. A scrollbar is automatically generated, if the total number of item are greater than the number of visible rows in the listbox.
SelectionMode : SelectionMode can be Single or Multimple. By default, this property value is Single, meaning when the listbox renders, the user can select only one item from the listbox. Set this property to Multimple, to enable multiple item selections. To select, multiple items from the listbox, hold-down the CTRL key, while the listitem's are selected.

Please note that, it is not possible to set the Selected property of more than one ListItem object to true, if the SelectionMode of the listbox is to Single.

ASP.NET RadioButtonList Control

1. RadioButtonList is also a collection of ListItem objects.
2. Items can be added to the RadioButtonList in the HTML source or in the code behind file
3. RadioButtonList like any other list control supports databinding. For example, RadioButtonList can be bound to a database table or an xml file

CheckBoxList is generally used, when you want to present the user with multiple choices, from which you want him to select one or more options. Where as if you want the user to select only one option, then a RadioButtonList control can be used, i.e RadioButtonList is commonly used to present mutually exclusive choices.

To retrieve the Text of the selected item, SelectedItem.Text property can be used. SelectedItem will be NULL, if nothing is selected, and hence, calling Text and Value properties may cause NullReferenceException. Hence, it is important to check for null, when using SelectedItem property of a RadioButtonList control.
if (ColorRadioButtonList.SelectedItem != null)
{
    Response.Write(ColorRadioButtonList.SelectedItem.Text);
}

NullReferenceException can also be avoided, using the SelectedIndex property
if (ColorRadioButtonList.SelectedIndex != -1)
{
    Response.Write(ColorRadioButtonList.SelectedItem.Text);
}

Bulleted list in asp.net
1. BulletedList is also a collection of ListItem objects.
2. Items can be added to the BulletedList in the HTML source or in the code behind file
3. BulletedList like any other list control supports databinding. For example, BulletedList can be bound to a database table or an xml file


Properties of BulletedList
BulletStyle - This property, is used to customize the bullets style. If CustomImage is specified as the BulletStyle, then BulletImageURL, also needs to be specified.
FirstBulletNumber - The Number at which the ordered list starts.

DisplayMode - Can be Text, HyperLink or LinkButton. The default is Text. 

Fileupload control in asp.net

The fileUpload control only allows the user to select the file. To upload the seleceted file, drag and drop a button control.

Asp.net calendar control

Any time we want your users of the application, to provide a date, it is better to provide a calendar control from which they can select the date.

Properties of the Calendar control
Caption - This is a string read/write property. 
CaptionAlign - Used to align the caption.
DayHeaderStyle - Style properties that can be used to customize the look and feel of the day header in the calendar
DayNameFormat - Can be Full, Short, FirstLetter, FirstTwoLetters, Shortest
DayStyle - Style properties that can be used to customize the look and feel of the day in the calendar
FirstDayOfWeek - Which day of the week is displayed first
NextPrevFormat - Can be ShortMonth, FullMonth, CustomText
NextMonthText - The text to use for the next month button. 
PrevMonthText - The text to use for the previous month button. 
SelectionMode - Can be Day, DayWeek, DayWeekMonth. Determines if Days, Weeks and Months are selectable.

If the SelectionMode is set to Day, then the user can select only one day. In this case to retrieve the selected date,However, if the SelectionMode is set to DayWeek or DayWeekMonth. In this case of you want to retrieve all the selected dates within the selected week or month, then SelectedDates property can be used as shown below.
Using SelectedDate, property returns only the first selected date of the week or month.
foreach (DateTime selectedDate in Calendar1.SelectedDates)
{
    Response.Write(selectedDate.ToShortDateString() + "<br/>");
}

Events:
SelectionChanged - Fires when the date,week or Month selection is changed, by the user.
protected void Calendar1_SelectionChanged(object sender, EventArgs e)
{
    foreach (DateTime selectedDate in Calendar1.SelectedDates)
    {
        Response.Write(selectedDate.ToShortDateString() + "<br/>");
    }
}

DayRender - Fires as a day in the calendar control is being rendered.
protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
{
    if (!e.Day.IsOtherMonth && e.Day.Date.Day % 2 == 0)
    {
        e.Cell.Text = "x";
        e.Cell.Font.Bold = true;
        e.Cell.ForeColor = System.Drawing.Color.White;
        e.Cell.BackColor = System.Drawing.Color.Red;
        e.Cell.ToolTip = "Booked";
    }
    else
    {
        e.Cell.ToolTip = "Available";
    }
}

VisibleMonthChanged - Fires when the visible month is changed by the user
protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
{
    Response.Write("Month changed from ");
    Response.Write(GetMonthName(e.PreviousDate.Month));
    Response.Write(" to ");
    Response.Write(GetMonthName(e.NewDate.Month));
}
private string GetMonthName(int MonthNumber)
{
    switch (MonthNumber)
    {
    case 1:
        return "Jan";
    case 2:
        return "Feb";
   .
   .
   . 
    }
}


Hidden field

The HiddenField control is used to store a value that needs to be persisted across posts to the server, but you don't want the control or it's value visible to the user. For example, when editing and updaing an employee record, we don't want the user to see the EmployeeId. So, we will store the EmployeeId in a HiddenField, so that it can then be used on the server to update the correct employees record.

1. Value property of the HiddenFiled is used to Get or set the value. 
2. The value is stored as string
3. ViewState uses HiddenFiled to maintain state across postback
4. HiddenField is rendered as an <input type= "hidden"/> element

Alternatives for HiddenField:
View state, QueryStrings, session state, and cookies can be used as an alternative for HiddenField. Session state and cookies will be accessible from other pages as well, and will be available untill their timeout has reached. Where as ViewState and HiddenField data, is available only on that page and the data is lost when you navigate away from the page. 

Advantages of HiddenField:
HiddenFiled data is lost when you navigate away from the page. Doesn't require any explicit cleanup task.
HiddenField is accessible to client-side scripts
<script type="text/javascript">
    function GetHiddenFieldValue() 
    {
        alert(document.getElementById('HiddenField1').value);
    }
</script>

Disadvantage of HiddenField:
Hidden field data can be seen, by viewing the page source. Never, use HiddenFiled to store confidential data

Multiview control
a multiview is made up of multiple view controls, and each view control inturn can have controls inside it.

The HTML Example shows a multiview, with 3 views
<asp:MultiView ID="MultiView1" runat="server">
    <asp:View ID="View1" runat="server">
    </asp:View>    
    <asp:View ID="View2" runat="server">
    </asp:View>
    <asp:View ID="View3" runat="server">
    </asp:View>
</asp:MultiView>

ActiveViewIndex property of the Multiview control is used to determine, the view that is visible or active.

This can also be achieved using the wizard control. We will discuss about wizard control in the next video session.

Another way to achieve this, is by creating multiple webforms and passing data between webforms using 
1. Cookies
2. Query Strings
3. Session variables

Wizard control
A wizard is a collection of WizardSteps. The StepType property of WizardStep determines the correct previous/next buttons to show. 

Properties:
ActiveStepIndex - Used to set or get the ActiveStepIndex of the wizard control
DisplayCancelButton - Determines the visibility of the cancel button in the wizard control
CancelButtonImageUrl - If the cancel button type is set to Image button. Then set this property to specify the image.
CancelButtonStyle - The style properties to customize the cancel button
CancelButtonText - If the cancel button type is set to Link or Button, then set this property to specify the Text of the button.
CancelButtonType - Use to Specify the type of cancel button. This can be Button, Image or Link.
CancelDestinationPageUrl - The destination page to redirect to, when the cancel button is clicked. This can be a page with in the application or an external website.
DisplaySideBar - Determines if the wizard sidebar should be displayed or not
FinishCompleteButtonType - The button type of the finish step's finish button
FinishPreviousButtonType - The button type of the finish step's previous button
HeaderStyle - The style properties to customize the wizard header
HeaderText - The header text of the wizard control
protected void Page_PreRender(object sender, EventArgs e)
{
    if (Wizard1.ActiveStepIndex == 1)
    {
        Wizard1.HeaderText = "Contact Details";
    }
    else if (Wizard1.ActiveStepIndex == 2)
    {
        Wizard1.HeaderText = "Summary";
    }
}



NavigationButtonStyle - The style properties to customize the wizard navigation buttons
NavigationStyle - The style properties to customize the navigation area that holds the navigation buttons
SideBarButtonStyle - The style properties to customize the wizard sidebar buttons
SideBarStyle - The style properties to customize the wizard sidebar
StartNextButtonType - The type of the start step's next button
StepNextButtonType - The button type of next step button
StepPreviousButtonType - The button type of previous step button
StepStyle - The style properties to customize the wizard steps

Literal control in asp.net
Asp.net panel control -> Creating controls dynamically using asp.net panel control


validator control

Validation controls are used to ensure if, the data, entered by the user is valid. It can be used to perform both client side and server side validation.Microsoft asp.net framework, provides 6 built-in validation controls. 
1. RequiredFieldValidator
2. RangeValidator 
3. RegularExpressionValidator
4. CompareValidator
5. CustomValidator    
6. ValidationSummary


Client scripts can spread viruses and cause security concerns. Because of this, users may disable JavaScript on their browser. If this happens, client side validation is skipped. That is why, it is always a good practice to have server side validation as well.
The validation control's also perform server side validation. Server side validation is always performed, irrespective of whether the client side validation is done or not.


Display property is supported by all validation controls.
None - Error message not rendered and displayed next to the control. Used to show the error message only in the ValidationSummary control
Static - The error message is displayed next to the control if validation fails. Space is reserved on the page for the message even if validation succeeds. The span tag is rendered with style visibility:hidden
Dynamic - The error message is displayed next to the control if validation fails. Space is not reserved on the page for the message if the validation succeeds. The span tag is rendered with style display:none.
SetFocusOnError property is supported by all validation controls. If this property is set to true, then the control will automatically receive focus, when the validation fails.


RequiredFieldValidator
<asp:TextBox ID="txtName" runat="server" Width="150px"> </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" runat="server" 
            ErrorMessage="Name is required" ForeColor="Red"
            ControlToValidate="txtName" Display="Dynamic" >
            </asp:RequiredFieldValidator>
TextBox with ID="txtName" expects the user to enter their name. This is required field. Next to this textbox is a RequiredFieldValidator control, which is used to ensure that the user has entered his name. ControlToValidate property specifies the control to validate. ErrorMessage is the message that is displayed when the validation fails. 


Rangevalidator 
Rangevalidator control. This control is used to check if the value is within a specified range of values. For example, Rangevalidator can be used to check if the age falls between 1 and 100.
<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" 
    ErrorMessage="Age must be between 1 & 100"
    MinimumValue="1" MaximumValue="100"
    ControlToValidate="txtAge" Type="Integer" >
</asp:RangeValidator>


CompareValidator 
CompareValidator control is used to compare the value of one control with the value of another control or a constant value. The comparison operation can be any of the following.
1. Equal
2. GreaterThan
3. GreaterThanEqual
4. LessThan
5. LessThanEqual
6. NotEqual
7. DataTypeCheck
CompareValidator can also be used for DataType checking.
Ex-
<asp:CompareValidator ID="CompareValidatorAge" runat="server"
            ErrorMessage="Age must be a number" ControlToValidate="txtAge"
            Operator="DataTypeCheck" Type="Integer" ForeColor="Red"
            SetFocusOnError="true"></asp:CompareValidator>


The following are the properties that are specific to the compare validator
1. ControlToCompare - The control with which to compare
2. Type - The DataType of the value to compare. String, Integer etc.
3. Operator = The comparison operator. Equal, NotEqual etc.
4. ValueToCompare - The constant value to compare with.


RegularExpressionValidator
This is a very powerful validation control. This control is used to check if the value of an associated input control matches the pattern specified by a regular expression. The only property that is specific to the RegularExpressionValidator is ValidationExpression.
EX- 
<asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" 
ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
ErrorMessage="Invalid Email" ForeColor="Red"></asp:RegularExpressionValidator>


CustomValidator
CustomValidator control allows us to write a method with a custom logic to handle the validation of the value entered. If none of the other validation controls, serve our purpose, then the CustomValidator can be used.
The following are the properties that are specific to the CustomValidator control
ClientValidationFunction - Specifies the name of the client side validation method.
ValidateEmptyText - Specifies whether the validator validates the control, when the text of the control is empty. By default this property is false, and both the client side and server side validation functions will not be invoked, if the associated input control is empty.


Events specific to the CustomValidator control
OnServerValidate - Specifies the name of the server side validation method.
ValidationSummary -> ValidationGroups in asp.net
ValidationSummary control is used to display a summary of all validation errors occurred in a Web page, at one place. In general, in a real time applications, it is very common to display a red star symbol next to the input control where the error occurred, and then the detailed error message in the validation summary control as shown below.


Properties specific to the validation summary control:
HeaderText - The header text for the validation summary control
ShowSummary - Whether to display the summary text of all the validation errors
ShowMessageBox - Whether to display a message box with all the validation errors
DisplayMode - Display format for the summary.


DisplayMode can be List, BulletList, SingleParagraph


 <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Page Errors" ShowMessageBox="True" ShowSummary="true" DisplayMode="List" />


Different page navigation techniques

1. Hyperlink control - Is used to navigate to another page. The page you want to navigate to is specified by the NavigateURL property. Using hyperlink, you can navigate to another page with in the same application or to an external web site. The hyperlink control is rendered as an HTML anchor tag.

2. Response.Redirect- Response.Redirect is similar to clicking on a hyperlink. The Hyperlink control does not expose any server side events. So when the user clicks on a hyperlink, there is no server side event to intercept the click.So, we you want to intercept a click event in code, use the Button, LinkButton or the ImageButton server control. In the button click event, call Response.Redirect() method. When the user clicks the button, the web server receives, a request for redirection. The server then sends a response header to the client. The client then automatically issues a new GET request to the web server. The web server will then serve the new page.
 Response.Redirect causes 2 request/response cycles.


when Response.Redirect is used the URL in the address bar changes and the browser history is maintained.
Response.Redirect() can be used to navigate pages/websites on the same web server or on a different web server.


3. Server.Transfer - Server.Transfer("~/WebForm2.aspx", true);

Differences between Server.Transfer and Response.Redirect
1. Just like hyperlink and Response.Redirect, Server.Transfer is used to navigate to other pages/sites running on the same web server.
2. Server.Transfer cannot be used to navigate to sites/pages on a different web server.
3. Server.Transfer does not change the URL in the address bar
4. Server.Transfer is faster than Response.Redirect as the redirection happens on the server in one Request/Response cycle. Response.Redirect() involves 2 Request/Response cycles.
5. With Server.Transfer the Form Variables from the original request are preserved.



5. Cross-Page postback- Cross page posting allows to post one page to another page. By default, when you click a button, the webform posts to itself. If you want to post to another webform on a button click, set the PostBackUrl of the button, to the page that you want to post to.
-> Cross page postback strongly typed reference




<asp:Button ID="btnCrossPagePostback" runat="server" 
                Text="Cross Page Postback - WebForm2" 
                Width="250px" PostBackUrl="~/WebForm2.aspx"/>


6. Window.Open
opening a new window using javascript method window.open(URL, name, features, replace)


URL (Optional)
The URL of the page to open. If URL is not specified, a new window with about:blank is opened.
Name (Optional)
Specifies the target attribute or the name of the window.
name - The name of the window
_blank - Opens in a new window. Default, if nothing is specified.
_self - Opens in the same page
_parent - Loaded into the parent frame
_top - URL replaces any framesets that may be loaded
Features (optional)
A comma-separated list of items.
resizable = yes|no or 0|1
scrollbars = yes|no or 0|1
toolbar = yes|no or 0|1
location = yes|no or 0|1(Specifies whether to display the Navigation Bar. The default is yes)
status = yes|no or 0|1
menubar = yes|no or 0|1
left = yes|no or pixels
top = yes|no or pixels
width = yes|no or pixels
height = yes|no or pixels
Replace(Optional)
A boolean parameter that specifies whether the url creates a new entry or replaces the current entry in the window's history list. This parameter only takes effect if the url is loaded into the same window.
true - url replaces the current document in the history list.
false - url creates a new entry in the history list.

.


Different techniques to move data from one webform to another 
1. Cross Page Postback
 Page previousPage = Page.PreviousPage;
    if (previousPage != null && previousPage.IsCrossPagePostBack)
    {
        lblName.Text = ((TextBox)previousPage.FindControl("txtName")).Text;
        lblEmail.Text = ((TextBox)previousPage.FindControl("txtEmail")).Text;
    }
    else
    {
        lblStatus.Text = "Landed on this page using a technique other than cross page post back";
    }
The problem with FindControl() method is that, if you mis-spell the ControlID, we could get a runtime NullRefernceException. 
Solution- Cross page postback strongly typed reference
There are 2 ways to obtain a strongly typed reference.
The first step in obtaining a strongly typed reference, is to create public properties. We want to convert the values of TextBox controls(txtName and txtEmail) into properties(Name and Email) respectively. The Name and Email properties are created as Read-Only properties, as we just need to read the values on the destination page.
//Name - read only property
public string Name
{
    get
    {
        return txtName.Text;
    }
}
//Email - read only property
public string Email
{
    get
    {
        return txtEmail.Text;
    }
}


The Second step to obtain a strongly typed reference to the previous page and access the public properties. This code must be in the Page_Load event on WebForm2.aspx.cs. If Name or Email properties are mis-spelled, we get an immediate compile time error. Hence, strongly typed references can eliminate runtime nullreference exceptions.
protected void Page_Load(object sender, EventArgs e)
{
    //Type cast PreviousPage to WebForm1
    WebForm1 previousPage = (WebForm1)Page.PreviousPage;
    if (previousPage != null && previousPage.IsCrossPagePostBack)
    {
        //Access the Name and Email public properties
        lblName.Text = previousPage.Name;
        lblEmail.Text = previousPage.Email;
    }
    else
    {
        lblStatus.Text = "You landed on this page using a technique other than cross page post back";
    }
}
2. Context.Handler object- In general, the members of one Web form are unavailable from a subsequently displayed Web form. However, when navigating between Web forms using the Transfer or Execute method, data can be retrieve from the previous Web form using Context.Handler object.
Points to remember 
1. Context.Handler returns WebForm1 as the previous page, only the first time when you land on WebForm2 from WebForm1. If there is a button on WebForm2, and if you click the button, the page will postback, and Context.Handler will return WebForm2 instead of WebForm1.
2. For the Context.Handler to return WebForm1 as the previous page, you should have landed on WebForm2, using Server.Transfer or Server.Execute method from WebForm1.
3. The control values from the previous page, can be accessed using FindControl() method or using public properties. The problem with FindControl() method is that, if you mis-spell the ControlID, we could get a runtime NullRefernceException. Using public properties, instead of FindControl() method, can eliminate runtime NullRefernceExceptions.


3. Query strings


Points to remember about query strings
1. Querystrings are name/value collection pairs
2. Using querystrings, is a very comman way to send data from one webform to another.
3. Query strings are appended to the page URL.
4. ?(Question Mark), indicates the beginning of a query string and it's value.
5. It is possible to use more than one query string. The first query string is specified using the ?(question mark). Subsequent query strings can be appended to the URL using the &(ampersand) symbol.
6. There is a limit on the Query string length. Hence, Query strings cannot be used to send very long data.
7. Query strings are visible to the user, hence should not be used to send sensitive information, unless encrypted.
8. To read the query string value, use Request object's QueryString property.
9. &(ampersand) is used to concatenate query strings, so if you want to send &, as value for the query string there are 2 ways, as shown below
Using Server.UrlEncode() method
Response.Redirect("WebForm2.aspx?UserName=" + Server.UrlEncode(txtName.Text) + 
    "&UserEmail=" + Server.UrlEncode(txtEmail.Text));


Or
&(ampersand) is encoded as %26, so use, Replace() function to replace & with %26
Response.Redirect("WebForm2.aspx?UserName=" + txtName.Text.Replace("&", "%26") +
    "&UserEmail=" + txtEmail.Text.Replace("&", "%26"));

4. Cookies -> How to Check if cookies are enabled or disabled
Cookies can also be used to send data from one webform to another. In general, web sites use cookies to store user preferences or other information that is client-specific. Cookies store small amounts of information on the client’s machine.

Cookies can be broadly classified into 2 types
1. Persistent cookies - Remain on the client computer, even after the browser is closed. You can configure how long the cookies remain using the expires property of the HttpCookie object.
2. Non-Persistent cookies - If you don't set the Expires property, then the cookie is called as a Non-Persistent cookie. Non-Persistent cookies only remain in memory until the browser is closed.

5. Session state -> Cookie less sessions in asp.net
Points to remember about session state variables:
1. Session state variables are stored on the web server by default, and are kept for the life time of a session.
2. The default session state mode is InProc. 
3. The life time of a session is determined by the timeout value in web.config file. The default is 20 minutes. The time-out value can be adjusted according, to your application requirements.in web.config file
<sessionState mode="InProc" timeout="30"></sessionState>
4. Session state variables are available across all pages, but only for a given single session. Session variables are like single-user global data.
5. It is always a good practice to check, if a session state variable is null before calling any of its methods, such as ToString(). Otherwise, we may run into runtime NullReferenceExceptions.
if (Session["Name"] != null)
{
    lblName.Text = Session["Name"].ToString();    
}
6. Application performance can be improved by disabling session state, if it's not required. Session state can be turned off at the page or application level.
To turn of the session state at the page level, set EnableSessionState="False" in the page directive
<%@ Page Language="C#" EnableSessionState="False" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AdoDemo.WebForm1" %>

To turn of the session state at the application level, set SessionState mode=false in web.config file.
<sessionState mode="Off"></sessionState>

session state mode management-Asp.net session state mode can have any of the following  values. Asp.net session state mode is set in web.config file.
1. Off - Disables session state for the entire application.

2. InProc. InProc session state mode: When the session state mode is set to InProc, the session state variables are stored on the web server memory inside the asp.net worker process. This is the default session state mode.

Advantages of InProc session state mode:
1. Very easy to implement. All that is required is, to set, the session state mode=InProc in web.config file.
2. Will perform best because the session state memory is kept on the webserver, within the ASP.NET worker process(w3wp.exe).
3. Suitable for web applications hosted on a single server.
4. Objects can be added without serialization

Dis-advantages of InProc session state mode:
1. Session state data is lost, when the worker process or application pool is recycled.
2. Not suitable for web farms and web gardens.
3. Scalability could be an issue.

Note: 
Web Garden - Web application deployed on a server with multiple processors
Web Farm - Web application deployed on multiple server 

                     

3. StateServer- When the session state mode is set to StateServer, the session state variables are stored in a process, called as asp.net state service. This process is different from the asp.net worker process. The asp.net state service can be present on a web server or a dedicated machine. 

Steps to follow, to configure asp.net web application to use StateServer:
1. Start the ASP.NET state Service. To start the asp.net state service
    a) Click Start > Type Run > Press Enter
    b) In the run window, type services.msc and click OK.
    c) In the services window, right click on ASP.NET State Service and select Start.
2. In web.config set sessionState mode="StateServer"
3. Set stateConnectionString="tcpip=StateServer:42424"
    Example: <sessionState mode="StateServer"     stateConnectionString="tcpip=localhost:42424"  
              timeout="20"></sessionState>

Advantages of using StateServer session state mode:
1. ASP.NET worker process independent. Survives worker process restart. 
2. Can be used with web farms and web gardens.
3. State server offers more scalability than InProc.

Dis-advantages of using StateServer session state mode:
1. StateServer is slower than InProc
2. Complex objects, need to be serialized and deserialized
3. If the StateServer, is on a dedicated machine, and if the server goes down all the sessions are lost.

4. SQLServer When the session state mode is set to SQLServer, the session state variables are stored in a SQLServer database.
SQLServer asp.net session state mode management

Advantages of using SQLServer session state mode:
1. SQLServer is the most reliable option. Survives worker process recycling and SQL Server restarts.
2. Can be used with web farms and web gardens.
3. More scalable than State server and InProc session state modes.

Dis-advantages of using StateServer session state mode:
1. Slower than StateServer and InProc session state modes
2. Complex objects, need to be serialized and deserialized

6.Application state
1. Application State variables are available across all pages and across all sessions. Application State variables are like multi-user global data.

2. Application State variables are stored on the web server.

3. Application State variables are cleared, only when the process hosting the application is restarted, that is when the application ends. 

4. Application State variables are not shared across a Web Farm or a Web Garden.



5. Application state variables are not thread safe. Lock and Unlock methods of the application class must be used to protect against race conditions, deadlocks, and access violations.
Application.Lock();
Application["GlobalVariable"] = (int)Application["GlobalVariable"] + 1;
Application.UnLock();

Please Note: In this example, we are using application state variables to send data from one web form to another. If the requirement, is just to send data from webform to another, you should consider other alternatives.

6. Use application state variables only, when the variables need to have global access and when you need them for entire time, during the life time of an application. Cache object, can be used, as an alternative, if you need to have global access for a certain duration.

Application state variables are global, and all sessions have access to them. So, these variables can be used to track the number of users online. Every time a new user connects to your application, we want to increase the number of users online by 1. Along, the same lines, when ever a user session ends, then we need to decrease the number of users online by 1. But how do we know, when a new user connects to our application. Session_Start() event is fired when ever a new session is established. When the session ends, Session_End() event is fired. The event handlers are in global.asax file.

Exception handling

Exceptions are unforeseen errors that happen within the logic of an application. For example, when reading a file, a number of exception conditions can occur.
1. The file might not exist
2. You may not have permissions to access the file

When an exception occurs and if it is not handled, then, that exception is called as an, unhandled exception. An unhandled exception is displayed to the user using an "yellow screen of death". Displaying the screen of death is bad for 2 reasons
1. The error messages are cryptic and may not make any sense to the end user
2. The exception information may be useful for a hacker, to hack into your application

Exception handling using - try-catch 
try - Wrap the code in a try block that could possibly cause an exception. If a statement in the try block causes an exception, the control will be immediately transferred to the catch block.
catch - catches the exception and tries to correct the error and/or handles the exception
finally - Used to free resources. Finally block is guaranteed to execute irrespective of whether an exception has occurred or not
throw - used to raise an exception

The base class for all exceptions is the Exception class. Specific exceptions should be caught, before catching the general parent exception.

Error events
Asp.net provide 2 error events
Page_Error - This event is raised at the page level, when there is an unhandled exception on the page. The event handler resides on the page.
Application_Error - This event is raised at the application level, when there is an unhandled exception at an application level. The event handler resides in Global.asax file

protected void Page_Load(object sender, EventArgs e)
{
    DataSet ds = new DataSet();
    ds.ReadXml(Server.MapPath("~/Data/Countries.xml"));

    GridView1.DataSource = ds;
    GridView1.DataBind();
}

protected void Page_Error(object sender, EventArgs e)
{
    // Get the exception details and log it in the database or event viewer
    Exception ex = Server.GetLastError();
    // Clear the exception
    Server.ClearError();
    // Redirect user to Error page
    Response.Redirect("Errors.aspx");
}

The code tries to read xml data from Countries.xml file. At the moment, the file is not present and we get a FileNotFound exception. Since this exception is not handled using a try/catch block in the Page_Load event, the eror get to the page level and is handled by Page_Error event handler. In Page_Error event handler
1. We get the exception information using Server.GetLastError() method.
2. Do something with the exception, such as redirect the user to a generic error page, display an error message on the same page which caused the exception, try to correct the problem, or log the exception to a database table or event viewer(using logger) and notify the development team. 
3. We then clear, the exception, so that it is not get propagated to the application level.
4. Finally we redirect the user to a generic error page, Errors.aspx

 Note

1. If the exception is not cleared in the Page_Error event, it gets propagated to the application level, and Application_Error event handler gets executed. If we are not clearing the exception at the application level, the application crashes with the "Yellow Screen of Death".
2. If the exception is cleared and redirection to Errors.aspx is not done, then a blank page is displayed.  This is because web form processing is immediately stopped when an exception occurs.

If an exception is not handled at the page level using Page_Error event, it get's to the application level and can be handled using the Application_Error event handler in Global.asax and can be used as a single, centralized location for error handling.

Custom errors
If there is an unhandled exception, by default, the generic yellow screen of death is displayed. Instead, custom error pages can be displayed. Custom error pages can be defined at 2 levels 
1. Application Level - In the web.config file using "customErrors" element.
2. Page Level - In the Page directive, using "ErrorPage" attribute. 
Page level custom error pages takes precedence over application level custom error pages.

Custom error pages provide the flexibility of displaying a specific page in response to one or more of the available HTTP status codes.
http://en.wikipedia.org/wiki/List_of_HTTP_status_codes- list of all the available HTTP status 

To specify the custom error pages at an application level, use customErrors element in web.config
<customErrors mode="On" defaultRedirect="DefaultErrorPage.aspx">
    <error statusCode="401" redirect="UnauthorizedErrorPage.aspx" />
    <error statusCode="404" redirect="PageNotFoundErrorPage.aspx" />
    <error statusCode="500" redirect="InternalServerErrorPage.aspx" />
</customErrors>

The mode attribute determines when a custom error page is displayed over the yellow screen of death, exception page. Mode attribute can have On, Off, or RemoteOnly. Default is RemoteOnly.
On - Custom error pages are displayed both on local and remote machines
Off - Custom error pages are not displayed anywhere
RemoteOnly - Custom error pages are displayed on remote machines, and exception page on local machine

If the redirection is done in Application_Error() event handler in Global.asax, custom error pages will have no effect.

In application, if we have to display specific custom error pages for specific http status codes, then use custom errors. If you just have one generic error page, then Global.asax can be used. 

Please note that, the exception object needs to be retrieved, before the user is redirected to a custom error page. Because a custom error page is displayed through redirection, the context for the error is lost and Server.GetLastError returns nothing from the target custom error page.

Windows event viewer- > Windows event viewer
Exceptions in an asp.net web application can be logged to the event viewer. 

To access the event viewer
Click on Start  - > Type "Run"->  type "eventvwr"

Under windows logs, we should see
1. Application - Logs information from applications like MS Office, SQL Server, Visual Studio etc.
2. Security - Logs information related to security like user sign-ons, access checks etc
3. System - Logs information related to driver, system service failures etc.

Logging exceptions to the windows eventviewer
Logging exceptions as information entry type in windows eventviewer
Logging exception to database
Customizing asp.net exception Logging
Sending emails using asp.net
Sending emails in asp.net using SMTP server settings from web.config
Tracing  -> Tracing in asp.net - A real time example
Tracing enables us to view diagnostic information about a request and is very useful when debugging application problems. 
Tracing can be turned on or off 
1. At the application level or
2. At the page level


To enable tracing at the application level set "trace" element's "enabled" attribute to "true" in web.config. This enables tracing for all pages in the application. 
<trace enabled="true"/>
To disable tracing for specific pages, set Trace="false" in the webform's "Page" directive
<%@ Page Language="C#" Trace="false" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>
If tracing is enabled at the application level, the trace messages are written to a file called trace.axd. Trace.xd file can only be accessed locally. To make the trace file available to remote users set localOnly="false". Tracing displays sensitive information, that could be useful to a hacker to hack into the server. So set this attribute to "false" only when it is required.
<trace enabled="true" localOnly="false"/>


To append trace messages at the end of the page set pageOutput="true".
<trace enabled="true" pageOutput="true" localOnly="false"/>
Use RequestLimit attribute to control the number of trace requests that are stored on the server. The default is 10. After this limit is reached, the sever will stop writing to the trace file.
<trace enabled="true" pageOutput="true" requestLimit="5" localOnly="false"/>


If you want to log trace messages, even after the requestLimit has reached set mostRecent attribute to true. When this attribute is set to true, the old entries in the trace log are discarded and the new entries get added.
<trace enabled="true" mostRecent="true" requestLimit="3"/>
To write custom asp.net trace messages Trace.Write() and Trace.Warn() methods can be used. The only difference, between these 2 methods is that, the messages written using Trace.Warn() are displayed in red colour, where as the messages written using Trace.Write() are displayed in black colour.
Anonymous authentication

Authentication is the process of identifying users. Authorization is the process of granting access to those users based on identity. Together, authentication and authorization secures our Web application.


Authentication - Who is the User?
Authorization - What rights the user has? What resources the user can access?
Most of the public web sites, does not ask the user to enter any user name and password. But still, we will be able to access the content of these web sites. ASP.NET Web applications provide anonymous access to resources on the server. Anonymous authentication allows users to access the public areas of the web site, without prompting the users for a user name or password.
? and * have special meaning when used in the authorization element in web.config
? (Question Mark) - Indicates anonymous users
* (Star) - Indicates all users


Allowing or denying access to specific users:
When you run the application, with the following authorization list in web.config, only users "Venkat" and "Pragim" are allowed to access the application. If you are logged, into the computer, as any other user, the application prompts the user to provide user name and password. All the other users are denied access to the application.
<authorization>
  <allow users="Prasad-PC\Venkat, Prasad-PC\Pragim"/>
  <deny users="*"/>
</authorization>


Using windows roles to control access:
Windows operating system has several roles, like Administrators, Guests, Users etc. It is also possible to control access to resources using these roles in the web.config file. The following authorization list, only allows users belonging to Administrators role. All the other users are denied access.
<authorization>
  <allow roles="Administrators"/>
  <deny users="*"/>
</authorization>
Anonymous authentication is fine for web sites that contain public information, that every one can see. However, if the web site contains private information or performs tasks such as booking tickets, placing orders etc, then the users need to be authenticated and authorised.
Security for an asp.net web application can be configured at 2 places. In IIS and in the application itself. 
Windows authentication, identifies and authorizes users based on the server’s user list. Access to resources on the server is then granted or denied based on the user account’s privileges. 
Windows authentication is best suited for Intranet Web applications.
The advantage of Windows authentication is that, the Web application can use the exact same security scheme that applies to your corporate network. User names, passwords, and permissions are the same for network resources and Web applications.
Forms authentication
Forms authentication is used for internet web applications. The advantage of Forms authentication is that users do not have to be member of a domain-based network to have access to your application. Many internet web sites like Gmail.com, Amazon.com, facebook.com etc uses forms authentication. To access these applications we do not have to be member of their domain-based network.
The description of the attributes
loginUrl - The URL of the login Page
timeout - Specifies the number of minutes the authentication cookie persists on the clients’s computer. The default is 30 minutes.
defaultUrl - The url the user will be redirected after authentication
Protection - Specifies the protection for authentication cookie stored on the clients’s computer. The default is All, which performs encryption and data validation. Other possible settings are Encryption, Validation, and None.


Secure Socket Layer 
HTTPS is HTTP (HyperText Transfer Protocol) plus SSL (Secure Socket Layer). SSL standing for Secure Sockets Layer (SSL) is a standard security technology for establishing an encrypted link between a web server and a browser, so that the data sent over the Internet can’t be read by others. When a user requests a secure Web page, the server generates an encryption key for the user’s session and then encrypts the page’s data before sending a response. On the client side, the browser uses that same encryption key to decrypt the requested Web page and to encrypt new requests sent from that page. SSL uses server certificates for encryption and decryption. An SSL certificate contains a public key and certificate issuer. Not only can clients use the certificate to communicate with a server, clients can verify that the certificate was cryptographically signed by an official Certificate Authority. For example, if your browser trusts the VeriSign Certificate Authority, and VeriSign signs my SSL certificate, your browser will inherently trust my SSL certificate.

Advantages of using HTTPS
HTTP stands for Hyper Text Transfer Protocol. HTTPS, stands for Hyper Text Transfer Protocol Secure. As the name suggests, HTTPS is more secure than HTTP. When the web server and the client communicate, using HTTP, protocol, the messages that are exchanged over the internet are not encrypted. Any one can secretly listen and see the messages that are exchanged between the client and the web server. That's why, any sensitive information like passwords, financial transactions should never be done over HTTP protocol. Most of the banking applications use HTTPS protocol. Messages exchanged between the client and web server, using the HTTPS protocol are encrypted and are very secure. HTTP use port 80 and HTTPS use port 443.
performance when using HTTPS over HTTP
Extra processing time is required for HTTPS, for key negotiation. Key negotiation is also termed as SSL handshake.  The handshake allows the server to authenticate itself to the client.

User controls
Web user controls combine one or more server or HTML controls on a Web user control page, which can, in turn, be used on a Web form as a single control. For example, to capture dates from the end user on a webform, we need a TextBox, ImageButton and, a Calendar control. A web form to capture date of birth is shown below in the image.


To select the date
1. User clicks on the calendar image.
2. The Calendar control becomes visible.
3. User selects a date from the calendar.
4. Textbox control is automatically populated with the selected date and the calendar becomes invisible.

If, we are capturing dates, on multiple web forms, rather than repeating the same HTML mark up and code, on each and every web form, we can encapsulate everything into a single web user control, which in turn, can be used on multiple web forms. This way we are reusing the same code, which saves a lot of time in terms of development and testing. So in short, user controls, increase re-usability of code, implement encapsulation and reduce development and maintenance time.

Designing and implementing web user controls is very similar to web forms.Web forms, have the extension of .aspx, where as web user controls have the extension of .ascx. Webforms begin with @Page directive and can have <html>, <head>, and <body> elements, where as a web user controls begin with @ Control directive and cannot have html, head, and body elements. Just, like webforms, user controls also have code behind files.

Difference between user controls and custom controls
Custom controls are compiled into their own assembly(.dll) where as user controls are not. User controls are compiled into the web application project's assembly that contain them.

Custom controls can be added to toolbox where as user controls cannot be added.

User controls are easier to create as they are similar to creating web pages. Custom controls are relatively complex, as there is no designer, and every thing has to be done in code.

A separate copy of user control is required in each application you want to use, where as a single copy of custom control can be used in multiple projects.Custom controls are compiled into their own assembly(.dll) where as user controls are not. User controls are compiled into the web application project's assembly that contain them.

Custom controls can be added to toolbox where as user controls cannot be added.

User controls are easier to create as they are similar to creating web pages. Custom controls are relatively complex, as there is no designer, and every thing has to be done in code.

A separate copy of user control is required in each application you want to use, where as a single copy of custom control can be used in multiple projects.

Caching
Caching improves the performance and scalability of an application. Caching is the technique of storing frequently used data/pages in memory.
To cache a webform, use the @OutputCache page directive. The @OutputCache directive has 2 mandatory attributes
Duration - Specifies the time in seconds for which the webform should be cached
VaryByParam - Cache multiple responses of a single webform. For now set the value to "None". We will discuss about "VaryByParam" in a later video.

Webform with the following "OutputCache" directive is cached for 30 seconds.
<%@ OutputCache Duration="30" VaryByParam="None" %>
 
Here 
<%@ OutputCache Duration="60" VaryByParam="DropDownList1"%>

Since "VaryByParam" is set to "DropDownList1", up to 5 different responses will be cached for this Web form. One for each possible selection from DropDownList1 control.
 
Fragment caching
Caching parts of webform is called as partial caching or fragment caching. In a web application development, there might be scenarios where most parts of the web page changes, but only a specific section of the page is static. Let's say that specific section also takes a long time to load. This is an ideal scenario, where fragment caching can be used.
Caching application data

Steps to fragment cache a webform
1. Encapsulate that sepcific sections of the page that does not constantly change into a user control. 
2. Use the OutputCache directive on the user control to specify the cache settings.
3. Drag and drop the user control on the webform. 

"Shared" attribute(only available in user control) can be used with "OutputCache" directive, to cache a single response from a user control for use on multiple Web forms. By default, ASP.NET caches a separate response for each Web form that uses a cached user control.
<%@ OutputCache Duration="60" VaryByParam="None" Shared="true" %>

Caching application data

It is possible to store application data in the web server memory, using the CACHE object, so that the data can be retrieved faster. For example, let us say, we have a stored procedure that takes 5 seconds to execute and return data. We can cache the data returned by this stored procedure with in an asp.net web application using the CACHE object, so that, next time when we try to access the data, we can get it from the cache, rather than reprocessing the stored procedure again.
        // Get the data from the database
        DataSet ds = GetProductsData();
        // Cache the dataset using the key "ProductsData"
        Cache["ProductsData"] = ds;
        // Set the dataset as the datasource
        gvProducts.DataSource = ds;
        gvProducts.DataBind();
Apart from caching data, using assignment, there are 2 other ways to cache application data
1. Using "Cache" object's Insert() method -Cache.Insert("ProductsData", ds);
2. Using "Cache" object's Add() method - Cache.Add("ProductsData", ds, null, System.Web.Caching.Cache.NoAbsoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Default, null);

When you cache an item using the Insert() or Add() method, you can also speicfy, how long you want the item to be cached. There are 2 ways to do this.

AbsoluteExpiration: A DateTime object that specifies when the data should be removed from the cache. When you specify "AbsoluteExpiration", the cache item will expire at that time, irrespective of whether the cached item is accessed or not. 
SlidingExpiration: A TimeSpan object that identifies how long the data should remain in the cache after the data was last accessed.

SlidingExpiration: A TimeSpan object that identifies how long the data should remain in the cache after the data was last accessed.

Cache dependency on files
When data changes in xml file or database , delete previous cache and store new saved changes.
Cache.Insert("CountriesData", ds, null, DateTime.Now.AddSeconds(20), System.Web.Caching.Cache.NoSlidingExpiration);

master pages
It is common for a web site to have a consistent look and behaviour across all the pages in the web application. 
To have a similar layout across all our pages, without the use of master pages. There are 2 options
Option 1: Copy and paste the following HTML across all pages in the application.
Option 2: Implement the layout using the following user controls.

Points to remember
1. html, head and body sections are not present on the content page, as they are already present on the master page, that this content page is subscribed to.

2. Content pages are associated with master pages using "MasterPageFile" attribute of the "Page" directive

3. Content control on a content page is linked to "ContentPlaceHolder" on the master page using "ContentPlaceHolderID" attribute of the "Content" control. Controls like textbox, button, gridview etc.. and any text that you want in the content page must be placed inside the content control. If you try to place anything outside of the content control, you would get an error - Only Content controls are allowed directly in a content page that contains Content controls.

4. When you flip the content page to design mode, notice that, the region outside of the "ContentPlaceHolder" is greyed out and disabled. This is because on a content page, you should only be able to edit "Content" that is specific to that page.

So, an asp.net master page allows us to define a common layout for all the pages in the application. Later, if we have to change something in the common layout, we only have to do it at one place, that is in the master page.

Menu control
Menu control in asp.net is used to display a menu in an asp.net web application.

The content for the Menu control can be specified directly in the control or the menu control can be bound to a data source. 

To configure styles for the statically displayed portion of the menu, use
StaticMenuStyle - Applicable for the entire statically displayed portion of the menu
StaticMenuItemStyle - Applicable for the individual menu items in the statically displayed portion of the menu
StaticSelectedStyle - Applicable for the selected menu item in the statically displayed portion of the menu
StaticHoverStyle - Applicable for the statically displayed menu item over which mouse is hovered over



To configure styles for the dynamically displayed portion of the menu, use
DynamicMenuStyle - Applicable for the entire dynamically displayed portion of the menu
DynamicMenuItemStyle - Applicable for the individual menu items in the dynamically displayed portion of the menu

DynamicSelectedStyle - Applicable for the selected menu item in the dynamically displayed portion of the menu
DynamicHoverStyle - Applicable for the dynamically displayed menu item over which mouse is hovered over

To configure styles for each level in the menu control, use 
LevelMenuItemStyles - If the menu control has 2 levels, you will have the html as shown below. MenuLevel1 css class will be applied for menu items at level 1. Along the same lines MenuLevel2 css class will be applied for menu items at level 2.
<LevelMenuItemStyles>
    <asp:MenuItemStyle CssClass="MenuLevel1" />
    <asp:MenuItemStyle CssClass="MenuLevel2" />
</LevelMenuItemStyles>

LevelSelectedStyles -  If the menu control has 2 levels, you will have the html as shown below. Yellow color will be applied for the menu item selected at level 1. Maroon color will be applied for menu item selected at level 2.
<LevelSelectedStyles>
    <asp:MenuItemStyle ForeColor="Yellow" />
    <asp:MenuItemStyle ForeColor="Maroon" />
</LevelSelectedStyles>

