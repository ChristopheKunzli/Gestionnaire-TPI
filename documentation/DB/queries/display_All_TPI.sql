SELECT tpi.title, tpi.year, tpi.remarks, tpi.duration, tpi.CDC, candidates.firstName, candidates.lastName, collaborators.firstName, collaborators.lastName
FROM tpi
LEFT JOIN candidates ON candidates.id = tpi.Candidates_id
LEFT JOIN collaborators ON collaborators.id = tpi.Collaborators_id