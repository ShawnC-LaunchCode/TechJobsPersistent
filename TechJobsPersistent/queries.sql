--Part 1
-- Id-int
-- Name-longtext
-- EmployerId-int


--Part 2
SELECT Name 
FROM employers 
WHERE Location = "St. Louis";
--Part 3
SELECT *
FROM Skills
JOIN JobSkills
ON Skills.Id = JobSkills.SkillId
WHERE JobSkills.JobId IS NOT NULL
ORDER BY Name ASC;
