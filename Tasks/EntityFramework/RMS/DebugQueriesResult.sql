SELECT [u].[UserID] AS [UserId], [u].[Name] AS [UserName], [u].[phone] AS [Phone], [r].[RoleName] AS [Rolename]
FROM [dbo].[User] AS [u]
INNER JOIN [dbo].[UserRoleMap] AS [u0] ON [u].[UserID] = [u0].[UserId]
INNER JOIN [dbo].[Roles] AS [r] ON [u0].[RoleId] = [r].[RoleId]
WHERE [u].[Status] = CAST(1 AS bit)


SELECT [s].[Name], [d].[DiningSetId], [d].[ChairCount]
FROM [dbo].[Section] AS [s]
INNER JOIN [dbo].[DiningSet] AS [d] ON [s].[SectionId] = [d].[SectionId]


SELECT [f].[Name] AS [name], [f].[Details] AS [details], [f0].[Name] AS [category], [f].[Price]
FROM [dbo].[FoodItem] AS [f]
INNER JOIN [dbo].[FoodCategory] AS [f0] ON [f].[CategoryID] = [f0].[CategoryId]