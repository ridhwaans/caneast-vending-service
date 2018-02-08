<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>

      <head>
        <meta http-equiv="Content-Language" content="en-us"/>
        <meta http-equiv="Content-Type" content="text/html; charset=windows-1252"/>
        <title>MachinesInOperation</title>
      </head>

      <body>

        <xsl:for-each select="MachinesInOperation/ActiveMachine">
          <table border="0" width="100%" cellspacing="0" cellpadding="3" id="table1">
            <tr>
              <td colspan="2" bgcolor="#E3E3D5">
                <font face="Verdana" size="4" color="#4684C1">
                  <xsl:value-of select="MachineInfo/MachineID"/>:
                  <xsl:value-of select="MachineInfo/ModelName"/>
                </font>
              </td>
            </tr>
            <tr>
              <td width="20%">
                <xsl:element name="img">
                  <xsl:attribute name="src">
                    <xsl:value-of select="MachineInfo/MachineImage"/>
                  </xsl:attribute>
                  <xsl:attribute name="width">124</xsl:attribute>
                  <xsl:attribute name="height">136</xsl:attribute>
                </xsl:element>
              </td>
              <td width="79%" display-align="after">
                  <font size="5" face="Arial">
                    Next Restock Date: <xsl:value-of select="MachineInfo/NextRestock"/><br/>
                  </font>

                <font size="2" face="Arial">
                  CustomerID: <xsl:value-of select="Customer/CustomerID"/><br/>
                  Customer: <xsl:value-of select="Customer/CustomerName"/><br/>
                  <xsl:value-of select="MachineInfo/Address"/><br/>
                  <xsl:value-of select="MachineInfo/City"/><br/>
                  <xsl:value-of select="MachineInfo/PostalCode"/><br/>
                  Contract Start Date: <xsl:value-of select="MachineInfo/ContractStartDate"/>
                </font>
              </td>
            </tr>
            <tr>
              <td colspan="2" bgcolor="#E4E4E4">
                <font face="Arial" size="2" color="#000080">Items</font>
                <xsl:for-each select="Items/Item">
                  <li>
                            <xsl:value-of select="text()"/>
                  </li>
                </xsl:for-each>
              </td>
            </tr>
          </table>
        </xsl:for-each>

      </body>

    </html>


  </xsl:template>

</xsl:stylesheet>