<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IProductos.aspx.cs" Inherits="WebApplication6.IProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <link rel="stylesheet"  href="custom.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
    <div align="center" class="container jumbotron bg-light boxshadow" style="width:100%;background-color:antiquewhite">
    <form>
       
        <div class="form-group" style=" width:90%;">
            <label class="text-dark" for="emailLabel">ID</label>
            <div class="input-group mb-2">
                <div class="input-group-prepend">
                   
                </div >
               <asp:TextBox ID="txt_producto" style="border-radius:20px; border-color:black" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>

        </div>
        <div class="form-group" style=" width:90%;">
            <label class="text-dark" for="emailLabel">Descripcion</label>
            <div class="input-group mb-2">
                <div class="input-group-prepend">
                   
                </div >
               <asp:TextBox ID="txt_descripcion" style="border-radius:20px; border-color:black" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>

        </div>
         <div class="form-group" style=" width:90%;">
            <label class="text-dark" for="emailLabel">Categoria</label>
            <div class="input-group mb-2">
                <div class="input-group-prepend">
                   
                </div >
               <asp:TextBox ID="txt_categoria" style="border-radius:20px; border-color:black" runat="server"   CssClass="form-control"></asp:TextBox>
            </div>

        </div>

            
      
        
            <asp:Button ID="Button2" style="border-radius:20px; runat="server" OnClick="btn_guardar_Click" Text="Guardar"  CssClass="btn btn-primary"/>
        
              <asp:Button ID="Button1" runat="server" OnClick="btn_modificar_Click" Text="Modificar"  CssClass="btn btn-primary"/>
        
        
              <asp:Button ID="Button3" runat="server" OnClick="btn_eliminar_Click" Text="Eliminar"  CssClass="btn btn-primary"/>
       
      
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
    </div>
    </form>
</body>
</html>

        
