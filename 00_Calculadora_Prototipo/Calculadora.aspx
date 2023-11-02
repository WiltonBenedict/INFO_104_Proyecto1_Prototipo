<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="_00_Calculadora_Prototipo.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            border-left-style: solid;
            border-left-width: 1px;
            border-right: 1px solid #C0C0C0;
            border-top-style: solid;
            border-top-width: 1px;
            border-bottom: 1px solid #C0C0C0;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style13 {
            text-align: center;
            width: 200px;
            height: 30px;
        }
        .auto-style14 {
            width: 200px;
            height: 23px;
            text-align: center;
        }
        .auto-style15 {
            text-align: center;
            width: 200px;
        }
        .auto-style16 {
            text-align: center;
            width: 110px;
        }
        .auto-style17 {
            text-align: center;
            width: 120px;
        }
        .auto-style18 {
            width: 100%;
        }
        .auto-style19 {
            text-align: left;
        }
        .auto-style20 {
            text-align: center;
            width: 241px;
        }
        .auto-style21 {
            text-align: left;
            width: 210px;
        }
        .auto-style22 {
            text-align: center;
            width: 243px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 class="auto-style1">Calculadora Prototipo Grupo 03 INFO-103</h1>
        </div>

    <table align="center" class="auto-style2">
        <tr>
            <td colspan="5">Valores:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="tValor" runat="server"></asp:Label>
            </td>
            <td rowspan="3" class="auto-style16">
                <asp:Label ID="tVal1STR" runat="server"></asp:Label>
            </td>
            <td rowspan="3" class="auto-style17">
                <asp:Label ID="tVal1DO" runat="server"></asp:Label>
            </td>
            <td rowspan="3" class="auto-style1">
                <asp:Label ID="tFuncion" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5">Entrada de datos:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="tDato" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5" class="auto-style6">Resultado:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="tResultado" runat="server"></asp:Label>
            </td>
        </tr>


        <tr>
            <td class="auto-style13">
                <asp:Button ID="bttRaiz" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="√" OnClick="bttRaiz_Click" />
            </td>
            <td class="auto-style13">
                <asp:Button ID="bttClear" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="C" OnClick="bttClear_Click" />
            </td>
            <td class="auto-style13">
                <asp:Button ID="bttRemover" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="&lt;" OnClick="bttRemover_Click" />
            </td>
            <td class="auto-style13">
                <asp:Button ID="bttFactorial" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="n!" OnClick="bttFactorial_Click" style="height: 26px" />
            </td>
            <td class="auto-style13">
                <asp:Button ID="bttDiv" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="/" OnClick="bttDiv_Click" />
            </td>
            <td rowspan="3" class="auto-style16">
                <asp:Label ID="tVal2STR" runat="server"></asp:Label>
            </td>
            <td rowspan="3" class="auto-style17">
                <asp:Label ID="tVal2DO" runat="server"></asp:Label>
            </td>
            <td rowspan="3" class="auto-style1">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Button ID="bttElevarXY" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="xⁿ" OnClick="bttElevarXY_Click" />
            </td>
            <td class="auto-style14">
                <asp:Button ID="btt7" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="7" OnClick="btt7_Click" />
            </td>
            <td class="auto-style14">
                <asp:Button ID="btt8" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="8" OnClick="btt8_Click" />
            </td>
            <td class="auto-style14">
                <asp:Button ID="btt9" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="9" OnClick="btt9_Click" />
            </td>
            <td class="auto-style14">
                <asp:Button ID="bttMult" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="*" OnClick="bttMult_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Button ID="bttElevar10" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="10ⁿ" OnClick="bttElevar10_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btt4" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="4" OnClick="btt4_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btt5" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="5" OnClick="btt5_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btt6" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="6" OnClick="btt6_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="bttRest" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="-" OnClick="bttRest_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Button ID="bttLog" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="log" OnClick="bttLog_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btt1" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="1" OnClick="btt1_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btt2" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="2" OnClick="btt2_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btt3" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="3" OnClick="btt3_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="bttSuma" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="+" OnClick="bttSuma_Click" />
            </td>
            <td rowspan="2" class="auto-style1" colspan="3">
                <asp:Label ID="tConsola" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">
                <asp:Button ID="bttElevarCuadrado" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="X²" OnClick="bttElevarCuadrado_Click" style="width: 25px" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="bttMasMenos" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="+/-" OnClick="bttMasMenos_Click" style="width: 30px" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="btt0" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="0" OnClick="btt0_Click" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="bttPunto" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="," OnClick="bttPunto_Click" style="height: 26px" />
            </td>
            <td class="auto-style15">
                <asp:Button ID="bttIgual" runat="server" BorderColor="#666666" BorderStyle="Dashed" Text="=" OnClick="bttIgual_Click" />
            </td>
        </tr>
    </table>

    <p>Opciones de un unico valor:<strong> Raiz Cuadrada, Elevado a 10, Elevado al cuadrado, Logaritmo, factorial</strong></p>
    <p>Opciones de dos valores: <strong>Elevar X a Y, Dividir, Multiplicar, Suma, Resta, igual.</strong></p>
    <p>Opciones que modifican datos string: <strong>Clear, remover ultimo valor, coma, mas menos.</strong></p>

    </form>
    <table class="auto-style18">
        <h1>Funcionalidad boton =</h1>
        <tr>
            <td class="auto-style20">Suma: (1)</td>
            <td class="auto-style20">Resta: (2)</td>
            <td class="auto-style21">Multiplicacion: (3)</td>
            <td class="auto-style22">Division: (4)</td>
            <td class="auto-style19">Elevar X a Y: (5)</td>
        </tr>
    </table>
    </body>
</html>
