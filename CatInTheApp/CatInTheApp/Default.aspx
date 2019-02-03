<%@ Page Language="C#" Inherits="CatInTheApp.Default" %>
<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" type="text/css" href="Font-Awesome-4.7/css/font-awesome.min.css">
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="css/templatemo-style.css">
    <link rel="stylesheet" type="text/css" href="css/ratingStyle.css">
    
    <title>Cat In The App</title>

</head>

<body>
    
    <div class="container">
        <section class="col-md-12 content" id="home">
           <div class="col-lg-6 col-md-6 content-item tm-black-translucent-bg tm-logo-box">
             <i class="fas fa-cat"></i>
             <h1 class="text-uppercase">Cat In The App</h1>
           </div>
           <div class="col-lg-6 col-md-6 content-item content-item-1 background tm-white-translucent-bg">
               <h2 class="main-title text-center dark-blue-text">Welcome!</h2>
               <p>Simple Web Application to return cat information.</p> 
                <form id="form1" runat="server">
                <table style="width:100%">
                    <tr>
                        <td><asp:DropDownList ID="CatBreeds" runat="server"></asp:DropDownList></td>
                        <td><asp:Button id="button1" runat="server" Text="Submit" OnClick="button1Clicked" /></td>   
                    </tr>
                </table>
               </form>
           </div>
       </section>


      <section class="col-md-12 content padding tm-float-section tm-section-3">

        <div class="col-lg-6 col-md-6 content-item tm-black-translucent-bg"></div>
        <div class="col-lg-6 col-md-6 content-item tm-white-translucent-bg"></div>
      
        <div class="tm-float-section-header">
            <h2 class="text-center tm-white-text tm-section-3-header">Cat Details: <asp:Label id="CatName" Text="" runat="server" /> </h2>  
        </div>

        <div class="tm-float-section-body tm-white-bg">
            <div class="col-lg-12">

            <p><b>Cat Description:</b></p>
            <p><asp:Label id="CatDesc" Text="" runat="server" /> </p>
            <table style="width:100%">
            <td><p><b>Life Span (Years):</b></p>
            <p><asp:Label id="lifeSpan" Text="" runat="server" /> </p>
            <p><b>Origin:</b></p>
            <p><asp:Label id="origin" Text="" runat="server" /> </p>
            <p><b>Temperament:</b></p>
            <p><asp:Label id="temperament" Text="" runat="server" /> </p></td>
            <th><asp:Image id="CatImage" runat="server"
                       AlternateText=""
                       ImageAlign="left"
                       border="5"
                       style="position: relative, centre: 9px; top: 14px;max-width:300px;border-radius: 50%;"
                       ImageUrl="" /></th>                 
            </table>
            <table style="width:100%">
              <tr>
                <th> Child Friendly:
                <asp:Literal ID="childFriendlyControl" runat="server" Text=""></asp:Literal></th>
                <th>Energy Level:
                <asp:Literal ID="energyLevelControl" runat="server" Text=""></asp:Literal></th> 
                <th>Vocalisation:
                <asp:Literal ID="vocalisationControl" runat="server" Text=""></asp:Literal></th>
               <th>Intelligence:
                <asp:Literal ID="intelligenceControl" runat="server" Text=""></asp:Literal></th>          
              </tr>
            </table>
            <br>
            <p><b>Wikipedia URL:</b></p>
            <asp:HyperLink id="wikiLink"
                           NavigateUrl=""
                           Text=""
                           Target="_new"
                           runat="server" />
 
            </div>
    
       </div>
    </section>


</div>

</body>
</html>