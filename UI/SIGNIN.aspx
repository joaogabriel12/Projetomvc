<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SIGNIN.aspx.cs" Inherits="PROJETOMVCB21.UI.SIGNIN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <link href="https://fonts.googleapis.com/css2?family=Comfortaa:wght@300&display=swap" rel="stylesheet">
    
    <link href="https://fonts.googleapis.com/css2?family=Fredoka+One&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="style.css">
</head>
<body style="background-color:aquamarine">
   
       <form id="form1" runat="server">
          <div class="row">
        <div class="col-3">
           
               </div>
           <div class="col-6">
                         <div class="card mt-4" style="width: 100%;border-color:blue;border-width:0.5px;border-radius:20px">
   <h2 class="mt-3" style="text-align:center; font-family:'Comfortaa', cursive ; color: blue";><b>Preencha Seus Dados</b</h2>

                            
                             <div class="d-flex justify-content-center">
               <asp:TextBox style="border-color: blue;border-radius:11px" placeholder="CPF" type="number"  CssClass="form-control mt-2 col-11" ID="txtcpfb21" runat="server"></asp:TextBox>
                                  
                                   </div>
                             <div class="d-flex justify-content-center">
                <asp:TextBox style="border-color: blue;border-radius:11px" placeholder="Nome Completo" CssClass="form-control mt-2 col-11" ID="txtnomeb21" runat="server"></asp:TextBox>
                                
                                 </div>
                             <div class="d-flex justify-content-center">
            <asp:TextBox style="border-color: blue;border-radius:11px" placeholder="Nome Da Mãe" CssClass="form-control mt-2 col-11" ID="txtnomemaeb21" runat="server"></asp:TextBox>
                                 
                                 </div>
                             <div class="d-flex justify-content-center">
                                 
                                 <asp:button ID="btnentrar" OnClick="Button1_Click" runat="server" Text="Enviar" style="border-color:blue;color:blue" class="btn btn-light mt-2"/>
                               
                                      </div>
                             <div class="d-flex justify-content-center">
                    <asp:Label CssClass="mt-3" Font-Size="10px" ID="msgerro" runat="server" ForeColor="Red" Text="." Visible="false"></asp:Label>


                             </div>
                               
 
</div>
              
           </div>
           </div>
          
    
    
    
         
       
               
   
    </form>
</body>
</html>