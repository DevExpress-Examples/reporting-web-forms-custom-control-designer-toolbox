<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Designer.aspx.cs" Inherits="CustomReportControlSample.Designer" %>

<%@ Register Assembly="DevExpress.XtraReports.v23.1.Web.WebForms, Version=23.1.1.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/html" id="dxrd-svg-toolbox-numericlabel">
        <svg viewBox="-2 -4 32 32" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink">
            <g id="Layer_1" transform="translate(-2, -4)" style="enable-background: new 0 0 32 32">
                <g id="Window">
                    <path d="M30, 10L30, 5C30, 4.5 29.5, 4 29, 4L3, 4C2.5, 4 2, 4.5 2, 5L2, 10L30, 10z" fill="#1177D7" class="Blue" />
                </g>
            </g>
            <g id="Layer_1" transform="translate(-2, -4.00000095367432)" style="enable-background: new 0 0 32 32">
                <g id="Window">
                    <path d="M28, 10L28, 26L4, 26L4, 10L2, 10L2, 27C2, 27.5 2.5, 28 3, 28L29, 28C29.5, 28 30, 27.5 30, 27L30, 10L28, 10z" fill="#727272" class="Black" />
                </g>
            </g>
        </svg>
    </script>

    <dx:ASPxReportDesigner EnableRichTextEditor="False" ID="ASPxReportDesigner1" runat="server">
    </dx:ASPxReportDesigner>
</asp:Content>
