SELECT technologies.name, technologies.siteLink
FROM technologies
LEFT JOIN tpi_uses_technologies ON tpi_uses_technologies.Technologies_id = technologies.id
LEFT JOIN tpi ON tpi.id = tpi_uses_technologies.TPI_id
WHERE tpi.title = 'Consultation et archivage des sujets donnés lors des PRE-TPI et TPI à l\'aide d\'une application c#'