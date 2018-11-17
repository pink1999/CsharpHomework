<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <head>
        <title>Orders</title>
      </head>
      <body>
        <ul>
          <xsl:for-each select="Order/Details/OrderDetails">
            <li>
              明细号
              <xsl:value-of select="Id"/>
            </li>
            
            <xsl:for-each select="Goods">
              <li>
                价格
                <xsl:value-of select="Price"/>
              </li>
              <li>
                名称
                <xsl:value-of select="Name"/>
              </li>
            </xsl:for-each>
            <li>
              数量
              <xsl:value-of select="Quantity"/>
            </li>
            
          </xsl:for-each>
              
          
        </ul>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>