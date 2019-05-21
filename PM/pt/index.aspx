<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage/masterpage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PM.pt.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphConteudo" runat="server">
    <section id="content">
<div class="camera-wrapper">
    <div id="camera" class="camera-wrap">
        <div data-src="../static/images/index_slide01.jpg">
            <div class="fadeIn camera_caption">
                <h2 class="text_1 color_1">Solução que você precisa!</h2>
                
            </div>
        </div>
        <div data-src="../static/images/index_slide02.jpg">
            <div class="fadeIn camera_caption">
                <h2 class="text_1 color_1">SUV</h2>
                <a class="btn_1" href="/pt/servicos/index.aspx">Detalhes</a>
            </div>
        </div>
        <div data-src="../static/images/index_slide03.jpg">
            <div class="fadeIn camera_caption">
                <h2 class="text_1 color_1">Acesse seu perfil</h2>
                <a class="btn_1" href="/pt/perfil/index.aspx">Detalhes</a>
            </div>
        </div>
    </div>
</div>
<div class="container">
    <div class="row wrap_1 wrap_5">
       
        <div class="grid_6">
            <div class="box_1">
                <div class="icon_3"></div>
                <h3 class="text_2 color_2 maxheight1"><a href="#">Perfil</a></h3>
                <p class="text_3 color_2 maxheight">
                    Acesse seu perfil para mais informações
                </p>
                <a class="btn_2" href="/pt/perfil/index.aspx">detalhes</a></div>
        </div>
        <div class="grid_6">
            <div class="box_1">
                <div class="icon_4"></div>
                <h3 class="text_2 color_2 maxheight1"><a href="#">SUV</a></h3>
                <p class="text_3 color_2 maxheight">
                    Entenda nossa causa.
                </p>
                <a class="btn_2" href="/pt/servicos/index.aspx">detalhes</a></div>
        </div>
    </div>
</div>



</section>

</asp:Content>
