<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:output method="html" encoding="UTF-8" indent="yes" />

	<xsl:template match="/">
		<html>
			<head>
				<title>Musiksammlung</title>
				<style>
					table {
					width: 100%;
					border-collapse: collapse;
					font-family: Arial, sans-serif;
					}
					th, td {
					border: 1px solid black;
					padding: 8px;
					text-align: left;
					}
					th {
					background-color: #333;
					color: white;
					}
					td:nth-child(1) {
					color: red;
					font-weight: bold;
					}
					tr:nth-child(even) td {
					background-color: #f2f2f2;
					}
				</style>
			</head>
			<body>
				<table>
					<thead>
						<tr>
							<th>Interpret<br/>Album</th>
							<th>Label<br/>Jahr</th>
							<th>Musikstil</th>
							<th>Aufgenommen von</th>
						</tr>
					</thead>
					<tbody>
						<xsl:for-each select="MUSIKSAMMLUNG/ALBUM">
							<tr>
								<td>
									<xsl:value-of select="INTERPRET" />
									<br />
									<xsl:value-of select="TITEL" />
								</td>
								<td>
									<xsl:value-of select="LABEL" />
									<br />
									<xsl:value-of select="JAHR" />
								</td>
								<td>
									<xsl:value-of select="TITEL/@stil" />
								</td>
								<td>
									<xsl:value-of select="AUTOR" />
								</td>
							</tr>
						</xsl:for-each>
					</tbody>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
