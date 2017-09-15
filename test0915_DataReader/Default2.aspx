<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="test0915_DataReader.Default2" %>
<%@ Import Namespace="System.Data" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style>
        table {
            border-collapse: collapse;
            width: 100%;
        }

        th, td {
            padding: 8px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        tr:hover {
            background-color: #f5f5f5;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>     
            <% foreach (DataRow dr in ds.Tables["Prod"].Rows) { %>           
                <tr>
                    <td><%=dr["ProductID"] %></td>
                    <td><%=dr["ProductName"] %></td>
                    <td><%=dr["UnitPrice"] %></td>
                    <td><a href="ProductDetail.aspx?id=<%=dr["ProductID"] %>">More...</a></td>   
                </tr> 
            <% } %>
            </table>
        
    </div>
    </form>
</body>
</html>
