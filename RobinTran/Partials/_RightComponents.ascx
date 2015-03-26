<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="_RightComponents.ascx.cs" Inherits="RobinTran.Partials._RightComponents" %>
<div id="content_right">
    <dl class="curved">
        <dt>
            <%= rm.GetString("rightWidgetChooseLanguage") %>
        </dt>
        <dd style="text-align:center;">
            <asp:ImageButton ID="imgButtonVN" runat="server" Height="50px" ImageUrl="~/Content/images/VNFlag.png" Width="70px" OnClick="imgButtonVN_Click" />
            <asp:ImageButton ID="imgButtonEN" runat="server" Height="50px" ImageUrl="~/Content/images/ENFlag.png" Width="50px" OnClick="imgButtonEN_Click" />
        </dd>
    </dl>
    <dl class="curved">
        <dt>RECOMMENDED LINKS</dt>
        <dd>
            <br />
            <ul id="navlist">
                <li><a href="http://www.free-css.com/">Snapp Happy</a></li>
                <li><a href="http://www.free-css.com/">Open Designs</a></li>
                <li><a href="http://www.free-css.com/">Andreas Viklund</a></li>
                <li><a href="http://www.free-css.com/">James Koster</a></li>
                <li><a href="http://www.free-css.com/">CSS play</a></li>
                <li><a href="http://www.free-css.com/">Listamatic</a></li>
            </ul>
            <p class="last">&nbsp;</p>
        </dd>
    </dl>
    <dl class="curved">
        <dt>CURVED CORNERS<span class="small"> by Stu Nicholls</span></dt>
        <dd>
            <p>Ok, finally a four corner box with no extra markup.</p>
            <p>No javascript and absolutely no hacks.</p>
            <p class="last">Examples at <a href="http://www.cssplay.co.uk">&#0187; CSS Play</a></p>
        </dd>
    </dl>
    <dl class="curved">
        <dt>MORE INFORMATION</dt>
        <dd>
            <p>Nulla in urna eu tellus auctor convallis.</p>
            <p class="last">Morbi sodales vehicula nisi. Donec id tortor. </p>
        </dd>
    </dl>
</div>
