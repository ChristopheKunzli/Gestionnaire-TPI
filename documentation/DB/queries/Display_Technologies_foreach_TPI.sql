SELECT tpi.title, technologies.name AS technology, technologies.siteLink AS 'official Site'
FROM tpi
LEFT JOIN tpi_uses_technologies ON tpi_uses_technologies.TPI_id = tpi.id
LEFT JOIN technologies ON technologies.id = tpi_uses_technologies.Technologies_id