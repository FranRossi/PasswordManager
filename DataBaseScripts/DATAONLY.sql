USE [PasswordManagerDB]
GO
INSERT [dbo].[Users] ([MasterName], [MasterPass]) VALUES (N'Juana', N'?u?|??CO??S5I??w#??]???6@O?ag')
GO
INSERT [dbo].[Users] ([MasterName], [MasterPass]) VALUES (N'Laura', N'??+????o??{?o???"?w??????jE??')
GO
INSERT [dbo].[Users] ([MasterName], [MasterPass]) VALUES (N'Mario', N'k?:???????????7OsL3?Q?k??X')
GO
INSERT [dbo].[Users] ([MasterName], [MasterPass]) VALUES (N'Pablo', N'uG?????3?=7?6?gHy*???JR????')
GO
INSERT [dbo].[Users] ([MasterName], [MasterPass]) VALUES (N'Santiago', N'?N%?????j??Se|''%`&?q?@??5?5S~')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (344, N'Personal', N'Juana')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (345, N'Trabajo', N'Juana')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (346, N'Facultad', N'Juana')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (347, N'Amigos', N'Juana')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (348, N'Familia', N'Juana')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (349, N'Personal', N'Pablo')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (350, N'Trabajo', N'Pablo')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (351, N'Facultad', N'Pablo')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (352, N'Juegos', N'Pablo')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (353, N'Familia', N'Pablo')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (354, N'Personal', N'Mario')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (355, N'Trabajo', N'Mario')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (356, N'Estudio', N'Mario')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (357, N'Importantes', N'Mario')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (358, N'Familia', N'Mario')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (359, N'Bancos', N'Laura')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (360, N'Tiendas', N'Laura')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (361, N'Facultad', N'Laura')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (362, N'Amigos', N'Laura')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (363, N'Negocios', N'Laura')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (364, N'Redes Sociales', N'Santiago')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (365, N'Celular', N'Santiago')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (366, N'Compras', N'Santiago')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (367, N'Otras', N'Santiago')
GO
INSERT [dbo].[Categories] ([Id], [Name], [User_MasterName]) VALUES (368, N'Juegos', N'Santiago')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1889, N'Numero aleatorio: 9', 344, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1890, N'Numero aleatorio: 9', 344, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1891, N'Numero aleatorio: 4', 344, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1892, N'Numero aleatorio: 4', 344, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1893, N'Numero aleatorio: 6', 344, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1894, N'Numero aleatorio: 2', 344, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1895, N'Numero aleatorio: 4', 344, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1896, N'Numero aleatorio: 5', 345, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1897, N'Numero aleatorio: 3', 345, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1898, N'Numero aleatorio: 1', 345, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1899, N'Numero aleatorio: 4', 345, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1900, N'Numero aleatorio: 4', 345, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1901, N'Numero aleatorio: 7', 345, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1902, N'Numero aleatorio: 3', 345, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1903, N'Numero aleatorio: 1', 346, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1904, N'Numero aleatorio: 1', 346, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1905, N'Numero aleatorio: 9', 346, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1906, N'Numero aleatorio: 6', 346, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1907, N'Numero aleatorio: 6', 346, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1908, N'Numero aleatorio: 7', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1909, N'Numero aleatorio: 3', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1910, N'Numero aleatorio: 9', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1911, N'Numero aleatorio: 9', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1912, N'Numero aleatorio: 2', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1913, N'Numero aleatorio: 4', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1914, N'Numero aleatorio: 2', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1915, N'Numero aleatorio: 8', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1916, N'Numero aleatorio: 4', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1917, N'Numero aleatorio: 5', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1918, N'Numero aleatorio: 4', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1919, N'Numero aleatorio: 7', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1920, N'Numero aleatorio: 9', 348, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1921, N'Numero aleatorio: 3', 348, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1922, N'Numero aleatorio: 6', 348, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1923, N'Numero aleatorio: 3', 348, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1924, N'Numero aleatorio: 1', 348, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1925, N'Numero aleatorio: 3', 348, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1926, N'Límite 400 shenn UYU', 344, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1927, N'Límite 400 shenn UYU', 346, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1928, N'Límite 400 shenn UYU', 347, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1929, N'Límite 400 shenn UYU', 348, N'Juana')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1930, N'Numero aleatorio: 2', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1931, N'Numero aleatorio: 3', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1932, N'Numero aleatorio: 2', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1933, N'Numero aleatorio: 4', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1934, N'Numero aleatorio: 8', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1935, N'Numero aleatorio: 8', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1936, N'Numero aleatorio: 4', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1937, N'Numero aleatorio: 1', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1938, N'Numero aleatorio: 4', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1939, N'Numero aleatorio: 1', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1940, N'Numero aleatorio: 1', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1941, N'Numero aleatorio: 4', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1942, N'Numero aleatorio: 9', 355, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1943, N'Numero aleatorio: 3', 355, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1944, N'Numero aleatorio: 6', 355, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1945, N'Numero aleatorio: 3', 355, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1946, N'Numero aleatorio: 5', 355, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1947, N'Numero aleatorio: 4', 355, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1948, N'Numero aleatorio: 2', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1949, N'Numero aleatorio: 8', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1950, N'Numero aleatorio: 2', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1951, N'Numero aleatorio: 3', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1952, N'Numero aleatorio: 8', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1953, N'Numero aleatorio: 3', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1954, N'Numero aleatorio: 9', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1955, N'Numero aleatorio: 2', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1956, N'Numero aleatorio: 4', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1957, N'Numero aleatorio: 9', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1958, N'Numero aleatorio: 1', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1959, N'Numero aleatorio: 4', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1960, N'Numero aleatorio: 2', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1961, N'Numero aleatorio: 4', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1962, N'Numero aleatorio: 9', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1963, N'Numero aleatorio: 3', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1964, N'Numero aleatorio: 2', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1965, N'Numero aleatorio: 4', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1966, N'Numero aleatorio: 1', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1967, N'Numero aleatorio: 9', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1968, N'Numero aleatorio: 8', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1969, N'Numero aleatorio: 2', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1970, N'Numero aleatorio: 6', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1971, N'Numero aleatorio: 8', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1972, N'Numero aleatorio: 7', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1973, N'Numero aleatorio: 9', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1974, N'Numero aleatorio: 8', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1975, N'Numero aleatorio: 6', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1976, N'Numero aleatorio: 1', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1977, N'Numero aleatorio: 4', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1978, N'Numero aleatorio: 5', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1979, N'Numero aleatorio: 5', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1980, N'Límite 400 shenn UYU', 354, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1981, N'Límite 400 shenn UYU', 356, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1982, N'Límite 400 shenn UYU', 355, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1983, N'Límite 400 shenn UYU', 357, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1984, N'Límite 400 shenn UYU', 358, N'Mario')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1985, N'Numero aleatorio: 9', 349, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1986, N'Numero aleatorio: 4', 349, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1987, N'Numero aleatorio: 7', 349, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1988, N'Numero aleatorio: 9', 349, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1989, N'Numero aleatorio: 1', 349, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1990, N'Numero aleatorio: 6', 349, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1991, N'Numero aleatorio: 3', 350, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1992, N'Numero aleatorio: 5', 350, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1993, N'Numero aleatorio: 5', 350, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1994, N'Numero aleatorio: 3', 350, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1995, N'Numero aleatorio: 9', 350, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1996, N'Numero aleatorio: 6', 351, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1997, N'Numero aleatorio: 8', 351, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1998, N'Numero aleatorio: 7', 351, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (1999, N'Numero aleatorio: 9', 351, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2000, N'Numero aleatorio: 7', 351, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2001, N'Numero aleatorio: 8', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2002, N'Numero aleatorio: 2', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2003, N'Numero aleatorio: 8', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2004, N'Numero aleatorio: 7', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2005, N'Numero aleatorio: 3', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2006, N'Numero aleatorio: 3', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2007, N'Numero aleatorio: 6', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2008, N'Numero aleatorio: 3', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2009, N'Numero aleatorio: 4', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2010, N'Numero aleatorio: 9', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2011, N'Numero aleatorio: 2', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2012, N'Numero aleatorio: 1', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2013, N'Numero aleatorio: 1', 353, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2014, N'Numero aleatorio: 6', 353, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2015, N'Numero aleatorio: 3', 353, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2016, N'Numero aleatorio: 1', 353, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2017, N'Numero aleatorio: 7', 353, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2018, N'Numero aleatorio: 8', 353, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2019, N'Límite 400 shenn UYU', 349, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2020, N'Límite 400 shenn UYU', 351, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2021, N'Límite 400 shenn UYU', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2022, N'Límite 400 shenn UYU', 352, N'Pablo')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2023, N'Numero aleatorio: 3', 359, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2024, N'Numero aleatorio: 9', 359, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2025, N'Numero aleatorio: 7', 359, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2026, N'Numero aleatorio: 8', 359, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2027, N'Numero aleatorio: 7', 359, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2028, N'Numero aleatorio: 1', 359, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2029, N'Numero aleatorio: 2', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2030, N'Numero aleatorio: 9', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2031, N'Numero aleatorio: 7', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2032, N'Numero aleatorio: 9', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2033, N'Numero aleatorio: 9', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2034, N'Numero aleatorio: 3', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2035, N'Numero aleatorio: 9', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2036, N'Numero aleatorio: 4', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2037, N'Numero aleatorio: 2', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2038, N'Numero aleatorio: 7', 361, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2039, N'Numero aleatorio: 3', 361, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2040, N'Numero aleatorio: 4', 361, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2041, N'Numero aleatorio: 5', 361, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2042, N'Numero aleatorio: 6', 361, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2043, N'Numero aleatorio: 9', 362, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2044, N'Numero aleatorio: 5', 362, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2045, N'Numero aleatorio: 7', 362, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2046, N'Numero aleatorio: 9', 362, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2047, N'Numero aleatorio: 6', 362, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2048, N'Numero aleatorio: 1', 363, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2049, N'Numero aleatorio: 5', 363, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2050, N'Numero aleatorio: 6', 363, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2051, N'Numero aleatorio: 1', 363, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2052, N'Numero aleatorio: 9', 363, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2053, N'Límite 400 shenn UYU', 360, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2054, N'Límite 400 shenn UYU', 359, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2055, N'Límite 400 shenn UYU', 361, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2056, N'Límite 400 shenn UYU', 363, N'Laura')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2057, N'Numero aleatorio: 2', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2058, N'Numero aleatorio: 2', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2059, N'Numero aleatorio: 4', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2060, N'Numero aleatorio: 4', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2061, N'Numero aleatorio: 7', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2062, N'Numero aleatorio: 6', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2063, N'Numero aleatorio: 1', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2064, N'Numero aleatorio: 6', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2065, N'Numero aleatorio: 7', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2066, N'Numero aleatorio: 5', 364, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2067, N'Numero aleatorio: 5', 365, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2068, N'Numero aleatorio: 3', 365, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2069, N'Numero aleatorio: 6', 365, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2070, N'Numero aleatorio: 7', 365, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2071, N'Numero aleatorio: 6', 365, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2072, N'Numero aleatorio: 5', 365, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2073, N'Numero aleatorio: 1', 366, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2074, N'Numero aleatorio: 8', 366, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2075, N'Numero aleatorio: 9', 366, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2076, N'Numero aleatorio: 9', 366, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2077, N'Numero aleatorio: 9', 366, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2078, N'Numero aleatorio: 7', 366, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2079, N'Numero aleatorio: 6', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2080, N'Numero aleatorio: 2', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2081, N'Numero aleatorio: 6', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2082, N'Numero aleatorio: 4', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2083, N'Numero aleatorio: 4', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2084, N'Numero aleatorio: 4', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2085, N'Numero aleatorio: 5', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2086, N'Numero aleatorio: 6', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2087, N'Numero aleatorio: 1', 367, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2088, N'Numero aleatorio: 4', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2089, N'Numero aleatorio: 2', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2090, N'Numero aleatorio: 2', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2091, N'Numero aleatorio: 1', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2092, N'Numero aleatorio: 7', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2093, N'Límite 400 shenn UYU', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2094, N'Límite 400 shenn UYU', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2095, N'Límite 400 shenn UYU', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2096, N'Límite 400 shenn UYU', 368, N'Santiago')
GO
INSERT [dbo].[Items] ([Id], [Notes], [Category_Id], [User_MasterName]) VALUES (2097, N'Límite 400 23 UYU', 344, N'Juana')
GO
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[DataBreachReports] ON 
GO
INSERT [dbo].[DataBreachReports] ([Id], [Date], [User_MasterName]) VALUES (22, CAST(N'2021-05-05T00:00:00.000' AS DateTime), N'Juana')
GO
INSERT [dbo].[DataBreachReports] ([Id], [Date], [User_MasterName]) VALUES (23, CAST(N'2021-05-15T00:00:00.000' AS DateTime), N'Juana')
GO
INSERT [dbo].[DataBreachReports] ([Id], [Date], [User_MasterName]) VALUES (24, CAST(N'2021-05-25T00:00:00.000' AS DateTime), N'Juana')
GO
SET IDENTITY_INSERT [dbo].[DataBreachReports] OFF
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1889, 0, N'amazon.net.br/10', N'2398510', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiRldXQ1ppY3VQQUxnSzN5MFpOZTRMUT09IiwibWFjIjoiOGUxMjg5NDNlNWE3ODcyNTUxYTM1ZjQxOGNiZGJjMTA1MjgzZTY5OTAzNGQ0MjcyYTg1NzUwYjU3ZjI0YjExYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1890, 0, N'amazon.co.uy/11', N'2398511', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiK1NoVlA4dHQ3QnZFb1ptMDlzU3lNdz09IiwibWFjIjoiNjI1YzkyNWU1NTJkOWRkYzAwZTE5NzUyNTA0MmQ2NWM3ZTE5OTQwZjllMTllYjRjYTlmZTllZDdhNWQ3YmQzMiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1891, 0, N'twitter.edu.uk/12', N'2398512', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiYmNIWHlDcjhGY1V5U0tEODVtSXZjUT09IiwibWFjIjoiZDhjNzA1ZDdhM2QwYzYzMTViYzlhZTkzNDg4YTJhZGJmOWIzYjU1OTQ2MjQyNGQzNDVjYmRkMjI3M2Y0NzU5ZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1892, 2, N'ort.net.eu/13', N'2398513', CAST(N'2021-06-14T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiU3JVMlJQckRLNXFEVU95QWNPaC94NU5GTCtzaXBCcW1lSXdRNjBGY1N6MD0iLCJtYWMiOiI1Njk0N2VhMDBmODcyYTdlMmEwYzMwNTc5NzQ1MjZmYzNjOGQ1NTdmODAyMTgzNjM2MDQ3OWE3MzFjNDRmMzMyIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1893, 2, N'amazon.edu.uk/14', N'2398514', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibkM1bVpQa0dUMFZMUlRPa3MwMTE0Zz09IiwibWFjIjoiYWZiN2E0ZTg4ZmExZTcxNjNlMDdjYmYxNTZkZDkxOGJkYzNlNzI5ZWJiNzFmODI0ZDBhMzI2M2MxNzNlMTY0YiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1894, 4, N'amazon.edu.br/15', N'2398515', CAST(N'2021-06-14T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic2NvTUFYaVA4SE5qMWQ0Qk9FbTN4UT09IiwibWFjIjoiOGI3YzBkNzAwNzAyNjZmMDliYzc2NzU3MDg2ZGI2NzJkNmY1OGQyOGY4ZWRlOGJmODM3OGQyMWI5NGRkZGRhNyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1895, 4, N'amazon.net.uy/16', N'2398516', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTFdCU1hXek5lUXNQUkJ1R05PdkJDdz09IiwibWFjIjoiZjk5OGFmNGEzYmVlMTk5NTVlZTdmMThkZjdkZjQzMDM1MWUyNTQ5ZjlmYTlkODQzMjU3YjMyNDQwZjZhZTQ2OSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1896, 1, N'bank.edu.eu/17', N'2398517', CAST(N'2021-06-14T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiejhXbUt0bmZYNW9GZTZoRFF0L0VuUT09IiwibWFjIjoiYjdiZDNhNTgwYTAwNDM1MWQxZGM3NTBlMWIxNTAwZjJjMGIyOTRhYjU0MTg1MjNkYzExNDU5ZjBiMDhiOTM1YiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1897, 1, N'facebook.com/18', N'2398518', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoidC9nY0YwbDR4cy91Uk1zenZhenlHdz09IiwibWFjIjoiNzY3YjAwZTQ0MTBlYmEyNjEwMzc1ZmRmYjgxNzQ4YmUzZDRmY2FlMDEwMDI0NWJkZDEyODFhZmVjZmIzOGU1MCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1898, 1, N'twitter.gob.eu/19', N'2398519', CAST(N'2021-06-14T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiaE5WSUplVWVJOVhVZWFUTUovbVdBZz09IiwibWFjIjoiMWVmY2U2MTY0NGQxYzRmODU4OGRjMjY0ZGM0MzFiZWMyYTZjZWZjYTQ2M2FhMjA4OWI5ZTNjNzU5OGFlZjU0OCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1899, 1, N'amazon.gob.uy/20', N'2398520', CAST(N'2021-06-14T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiZ09ZVHFScG1aV1FDTVJyRTlUeU5hdz09IiwibWFjIjoiODA2ZWUzNzQ5MGQyMDgxODYwNTk5ZWQ1MzA0YWM0NTg1NjhlZDkyN2RjM2ZhNWFiZTUyODZhODA4YjU2NGEzYyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1900, 1, N'bank.gob/21', N'2398521', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibURWVkdwVnJodWd4RmZHbE02MFJTdz09IiwibWFjIjoiMWYyZTU1ZWM4NDI5NDlmMTJiNTQwMTAxNzE2M2NkMzEyOGY4YjBjYWQ4NTQ5NWEwMTM4ZGFhZjg0ZDhlMGQ0NyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1901, 3, N'amazon.net.br/22', N'2398522', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTk9CZC84RFRPT0R2eDZsWnk1SE1lU05VTndad0szMWZkNzFjYWhFeGhkcz0iLCJtYWMiOiJjYTFmYmM1NjEwMDAzNmVkMmRlYmMyNDlmNDZmM2UyMTI4MjlkNTZlYjRhZjAyY2UxY2RkZTEzYmI1YWMzNTQ3In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1902, 3, N'bank.gob.uy/23', N'2398523', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiZnJDVDBkQkFJNm9nR1RERGZLMUJuSDFZanFmL3kvOU0xWm9pSTZrNmJqQT0iLCJtYWMiOiI3N2FlMmNjMjc1YjFhMTgyMzFjMjZkY2IyOWI1MDNmZjc0NzQ1YjYzZDQ0ZDRkNWNjNzIyYTJkYzY1NzlhMzE1In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1903, 1, N'ort.edu.eu/24', N'2398524', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUWExdHk5dXpuekxvSTVkVTVpQUtEQT09IiwibWFjIjoiODgzNjRjYjIyNTFmNGM1MjgwZjAwN2FiZmY1YWM5ZGIwNWYzODc2YjY2YmMwNzkxM2IxNDkxMDEzNmFlOTY0OCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1904, 1, N'amazon.com.uy/25', N'2398525', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiL3RDNVQxMVc4YVVxenBrNXZMVGR2dz09IiwibWFjIjoiZDZiYjNlMWQzMzJjM2EzZjMwMGJmMmIwNTA1MmIzNjNiZjUzMzcxOWQ5MTQyMjZmZDIzYmQ3MTVhMTc3YjJmMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1905, 1, N'amazon.com.uk/26', N'2398526', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiNTNRbS9qT1RBN2V6TTFGWWJjek9Udz09IiwibWFjIjoiYzYyY2Q5ZWNhMzU2NDg4YzI3OTBkMGFhMzg5NWZhOTlhMjJhZTAyYWU0OTI1OGRiYmQxYTU2YTZlNzk5MzdhYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1906, 4, N'amazon.net.eu/27', N'2398527', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiL2VLN2p2ZVdzK1VXdmRpUTVEZitsQT09IiwibWFjIjoiMzM1MmYyYTI3ZmZmMDFlZWFlMDM1ODYzZjQzNzY5ZDQ3OWQ4MDI1ZjA3Mjg3YjcwMTdlNDYyZmMzZDVlZGFjMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1907, 4, N'amazon.gob.uy/28', N'2398528', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoid2pZbldVN21iRGE1bFRKYTVNVWMrUDY4Q0huMlBNVXNDMnhKOTErK0dmND0iLCJtYWMiOiI2Yzk4ZTFiODNkNzI2NmEwZGE1YzgwZTQyNjFlYzE5YmJiYjJmYjBiOGYyM2E5YjNhNWVhMDdhMDFmY2I1YzI0In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1908, 0, N'bank.gob.uk/29', N'2398529', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUWc3d1o1WC9zMnZhL2ZmRjExM2dqZz09IiwibWFjIjoiYTQ1ZmFhYTMxOWUzNGYwNzBkOWFlMzcwNzJkMjkyMjI5YzhkMzk2ZjgwMTgxOGIyZWViNGNjNGE2MjA0NGJmZSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1909, 0, N'bank.edu/30', N'2398530', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTVJyS2kyRG9QdkFRS0xnWmZ5WmEyZz09IiwibWFjIjoiYjQxMTMxNTA4YzFiMjI4ZTlmZTA3Mzg3ZjkwM2MzODE4MTRjYjljYTg0MzFlZDg3MjYzNDU5MTQ3YzkyZDFjNSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1910, 0, N'facebook.edu/31', N'2398531', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiYmNIWHlDcjhGY1V5U0tEODVtSXZjUT09IiwibWFjIjoiZDhjNzA1ZDdhM2QwYzYzMTViYzlhZTkzNDg4YTJhZGJmOWIzYjU1OTQ2MjQyNGQzNDVjYmRkMjI3M2Y0NzU5ZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1911, 1, N'facebook.gob.br/32', N'2398532', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiRkxpekpIc0RhQUxxS1lRak9ZWXJLUT09IiwibWFjIjoiNWIzMWNhNTgzNjYyOWJlNDRiNzA5NDk0YTVjZjM5ODllYmFkMDRkMjdkZjZmMTdmMmIzZDQyMzk2ZDY3MmFkOSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1912, 1, N'ort.co.uk/33', N'2398533', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoianFSUTQrWERmcmFBV2ZhdzVrK25CUT09IiwibWFjIjoiY2ViZjZlMjA5Y2M4ZTQzMzQzNjIyM2M4Y2UwZmU1OGQ3YmRiMmJkNDgxZjEwMzMyMDYyODg5M2FmYTk0NTIyOSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1913, 1, N'amazon.net.br/34', N'2398534', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTDBtQXZkUXZlQmc4R0xzQ1FkMm53UT09IiwibWFjIjoiOGIxMzYyNDliZjJiMzM1OWVjMGIyMWFhMTBiODY0MmM2ODkzMTM4ZjkzYTY3YWNmZjc3ZmUyNWEwMTk2N2U3ZSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1914, 2, N'twitter.edu.br/35', N'2398535', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUHo0dWUycXVYRUlSNVJVMU5ycGY4R3Q0cCs3SUt0dG83cmc1U05wakZqQT0iLCJtYWMiOiJjMmQ0MjY4ODY1ZTZmNDY2YmEzMzVlODcxNjI4Y2NiNmQxNzEzMTBjNDg5ZDU2NTgwOWQ2MDEzZDk5OWY4ZGM3In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1915, 2, N'facebook.co.uy/36', N'2398536', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWVlZZGZGY1hMTXgzT1J4RS94VHB5eVYvTWErUlBwbDhEWFZyWVI2ekxtST0iLCJtYWMiOiIwZTExMjE5OGM5OGQ2MmNmYjg5OThiZDA3OWFkZTYwNDA4MWMzYWRlZmNlMTRjOWI2M2MwMGQ4MWQ5Zjg2N2VhIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1916, 3, N'amazon.gob.uk/37', N'2398537', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoieVUyeDc5Tkg3YVlLUnBMeERnNi9leWU2UHI0NjlXZlVRSmhVUUFsYXBZVT0iLCJtYWMiOiIyMTg0N2I2ZmM0NzRlYTQzYjYxMDUzZWYzNDFhMjM4MzdlZmQ2MmZjM2JmNzcwYmQ0NDZhM2E2NDhhZWIxNzNlIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1917, 0, N'amazon.edu.eu/38', N'2398538', CAST(N'2021-06-14T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiRS9xczVpRlJMZDR5Q1VNV2JoN2FIQT09IiwibWFjIjoiOGUwMDY3ZTQ4YmMyODZjNTNiOTgwMWRkMjlhMWU2Yjg4YWJmMTU2ZjEyMzBhMjFmYzBkZmRhNjk0YjhiYzdiNSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1918, 4, N'ort.com.uy/39', N'2398539', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiaTNqNFVDT1podzRYa3B0REFmbU1JZz09IiwibWFjIjoiMDI1YzdjMjA1NTI5NjczMGY1ODI0ZmZmNDA1M2EzNDU0MzAyYzMxYWQyNzI0MGZlMjA4MTgyYWUyMzVlNThjMyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1919, 4, N'amazon.gob.uy/40', N'2398540', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTFdCU1hXek5lUXNQUkJ1R05PdkJDdz09IiwibWFjIjoiZjk5OGFmNGEzYmVlMTk5NTVlZTdmMThkZjdkZjQzMDM1MWUyNTQ5ZjlmYTlkODQzMjU3YjMyNDQwZjZhZTQ2OSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1920, 1, N'ort.co.eu/41', N'2398541', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiL3RDNVQxMVc4YVVxenBrNXZMVGR2dz09IiwibWFjIjoiZDZiYjNlMWQzMzJjM2EzZjMwMGJmMmIwNTA1MmIzNjNiZjUzMzcxOWQ5MTQyMjZmZDIzYmQ3MTVhMTc3YjJmMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1921, 1, N'ort.com.uy/42', N'2398542', CAST(N'2021-06-14T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVkg1eEZ6LzRDS1N3Z2ZZMHRKZjlZdz09IiwibWFjIjoiOTY0NWRiNTVkYzRhZjg5ZWRlYTFiZTljYjFjNWM3NjFkMDNlODIxYTdiYTNhZGFiOTAxNWU4YmRmMzdjMmQ2MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1922, 1, N'bank.net.uk/43', N'2398543', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicGc1T0prWG56eFhuQjFIOHA0RGtLdz09IiwibWFjIjoiNDBhYTAwMTFlYzQ0NTNhODgzYWYzNDVmMzc4MTBhM2FlNGY4YTJhMmM5MmU2MWExYTg0ZDc2MGVkNGRkMjA4MCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1923, 1, N'facebook.edu.eu/44', N'2398544', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibURWVkdwVnJodWd4RmZHbE02MFJTdz09IiwibWFjIjoiMWYyZTU1ZWM4NDI5NDlmMTJiNTQwMTAxNzE2M2NkMzEyOGY4YjBjYWQ4NTQ5NWEwMTM4ZGFhZjg0ZDhlMGQ0NyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1924, 1, N'bank.com.uk/45', N'2398545', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiM3ljSFJyYTdLa2JKQ2kyMTdVWWZXdz09IiwibWFjIjoiMzAzZjBmYjEwNzYyMTMxYjA1Yjk4Yjc0MmRjYWJlOTlhYjc4NDE3M2QwNWE5ZjJhYjUxMWU0M2Y1OTE3NWRmMiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1925, 1, N'twitter.gob.uk/46', N'2398546', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic29lT0FhOW1iODhtWU1kWldCRzdSQT09IiwibWFjIjoiM2M1M2UwOWMyNzYzYzM0M2Q1MDUyY2ZlM2NjZTYxZWZhN2Y5ZGNiN2Y5ODZmYjQ5ZmQwMjY2NmI2ZmU4YjkwMSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1930, 0, N'amazon.co/51', N'2398551', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUlVBZHNJaUsvL0RSOUJCaHpGQlJsdz09IiwibWFjIjoiMmMzZTE5ODk5ZWViODdhOTgxNDhiNTc0NTQ2ODQ3ZTY0ZmFhYTIyNjFlNGUxYjFhYmRmODEzYjJmNDIwYzA5NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1931, 0, N'ort.edu.uk/52', N'2398552', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiZGdvbWEzQ2RpWjlib0xLUU5lM1RYZz09IiwibWFjIjoiN2Y3MGRkMjc3NmEzN2VhY2EwOWUwYjAwNDZjODQ3OThjODVlYTNmNDNiN2RiNTYzNjRhY2VjNDE0MjU2NzFlNCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1932, 0, N'bank.edu/53', N'2398553', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiamQraU52N2NuM0dWS0p6NUdrNHZMZz09IiwibWFjIjoiNDM0OTBmODk4MWZkNTMzNDUwYjU2ZjdhMTY0ZmEzYjk3NjUxZjgyMzNkMjU0YWVkOTQ0Y2U0ZDZjOGVmMzJkMiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1933, 1, N'twitter.net.uk/54', N'2398554', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia2lKSHEyMjlhNmE3WUdBUk5peDhzQT09IiwibWFjIjoiYjRiYTRjNzJhNmZiY2YwODE5ODkwNmI3MjdkMTU4NGNiMmRhYTM3YWRkM2NmZTRlNmU4MWQ2YjI2ZjgyYmFlYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1934, 2, N'twitter.com/55', N'2398555', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicEo3T1pIMXNvVS82WUJtMkZuUGp6YS9jc2ZaMmx2QlRVbjh5ZVh3NlhxST0iLCJtYWMiOiJkYzlhYjA3YjhhMWMyZjIxNGVmNWYzY2M0YjY2OWY2Zjg1MGVmODNiMjU0NzkzYmI3N2E2Y2FkMDBiNGJmYTAwIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1935, 2, N'ort.com.uy/56', N'2398556', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiMjBkNm1Mb0toME9JcXhURzdjcmtjZmlIQ1FxZUtXMXpEZmlZVDduL3hkVT0iLCJtYWMiOiI4MWVjOGQ0MzE2NjQ1ODkyYzY0YzUxYmU1Nzk2ODE5YjU4Nzg4ODgwNGMxMGU0YmFjYzdiZjVkNTM5ZmM3NzMzIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1936, 2, N'twitter.co.br/57', N'2398557', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiMjNmMTRFZmlkVitwbUJOZ3hiMkJKdz09IiwibWFjIjoiNzA2ZmJiNjgwZTNhM2U5NjY0NGJhZDMyNGRlYTNkMThlZjg5YzVmNzdkODA2MTZlMTY0MGIxYzQ0MDMxMzdkZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1937, 2, N'facebook.net.uy/58', N'2398558', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicHlodnl5NlBLWVZUeFdielJwVC9lcXlqSTltSEhRTHJOWFVLVzRqeXA3ST0iLCJtYWMiOiJmY2Y2MzkzNzU2M2U1N2Y3M2NiYWU1Y2Y4Y2FmNWM1MTkzYzdhZWU2NDc0ODQ3N2M3ZTFkMzYzN2YzZDFmMTJmIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1938, 2, N'amazon.co.uk/59', N'2398559', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVmJlbCtpTzJNaEl5S1hhZ1hHRnBXdz09IiwibWFjIjoiYTU0OGQwZWNjNmQ0N2U0NWZiOWM3MmUzZGFjMTFlOTMyZTgwMzU4YzhiYmFmYjE4ZmUwYTBlM2EwNGZkNDUyYiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1939, 3, N'twitter.co.br/60', N'2398560', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic0ZNSzFtbjJDYWpPNkZicHlqMjM3d3lJM2dRdmEwSmlxRjJ4Uk8vYUQybz0iLCJtYWMiOiJhYjczNjEyMjBiMzc1NjMyMWRiMjlmODY5YmRkOTVhNjA2ODg1NDY4YmFhODY5Y2VhZTRlMzY4ZDJmYTcxODNjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1940, 4, N'bank.edu.uk/61', N'2398561', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUjBTZ3M4dzBZeHRLV1dXa1VaQ0MrQT09IiwibWFjIjoiYTRjMjlmZGYxMDRmZDE4MTFmNjg5MmY5ZTQ3NDI2MTBkZjJkMTBkNmExNDliZjU5YTg5YzY0YzRhYmQ5NDg3MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1941, 4, N'facebook.com.uy/62', N'2398562', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoieGhyRlpNU1lqTG9KY0swcUpKN0NuampRamVSUWt0YStiMllJRmhXd2xQbz0iLCJtYWMiOiIzZjI1NjY4NzM1N2EzMmFlMzBjYjFlOTFiZDE3Yjg2ZmZiYzczODYxMzI5NzQ2ZDVkYTUxZGVmYzhlMjdjMjQ1In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1942, 0, N'bank.gob.uy/63', N'2398563', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUlVBZHNJaUsvL0RSOUJCaHpGQlJsdz09IiwibWFjIjoiMmMzZTE5ODk5ZWViODdhOTgxNDhiNTc0NTQ2ODQ3ZTY0ZmFhYTIyNjFlNGUxYjFhYmRmODEzYjJmNDIwYzA5NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1943, 2, N'bank.edu.br/64', N'2398564', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVmJlbCtpTzJNaEl5S1hhZ1hHRnBXdz09IiwibWFjIjoiYTU0OGQwZWNjNmQ0N2U0NWZiOWM3MmUzZGFjMTFlOTMyZTgwMzU4YzhiYmFmYjE4ZmUwYTBlM2EwNGZkNDUyYiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1944, 4, N'ort.com.br/65', N'2398565', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiakpxdkc0TDFvcXlKelJrd1lQOW1qUT09IiwibWFjIjoiMjFkZTVlYzkwM2MzNjBiOTNmMTdlODhkNzU0OGVhZDhlYmI3NTY2OGIxMzU4NDU2YmEyOTc2MWQ4MzAyOGYzOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1945, 4, N'twitter.net.eu/66', N'2398566', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiRkcrWlV1cDh2NFppcGpubXVZUXlHZz09IiwibWFjIjoiMmVhYzY2NTcwOGNlZmZlODQwMjE1OGNlOTczMzBmZmY5MzgxMTljMzNjNDQwMGE2ZjBlOTg0NjNmMzY0MjEwMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1946, 4, N'facebook.edu/67', N'2398567', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUjBTZ3M4dzBZeHRLV1dXa1VaQ0MrQT09IiwibWFjIjoiYTRjMjlmZGYxMDRmZDE4MTFmNjg5MmY5ZTQ3NDI2MTBkZjJkMTBkNmExNDliZjU5YTg5YzY0YzRhYmQ5NDg3MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1947, 4, N'bank.net.uk/68', N'2398568', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoieGhyRlpNU1lqTG9KY0swcUpKN0NuampRamVSUWt0YStiMllJRmhXd2xQbz0iLCJtYWMiOiIzZjI1NjY4NzM1N2EzMmFlMzBjYjFlOTFiZDE3Yjg2ZmZiYzczODYxMzI5NzQ2ZDVkYTUxZGVmYzhlMjdjMjQ1In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1948, 0, N'twitter.edu.uy/69', N'2398569', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUlVBZHNJaUsvL0RSOUJCaHpGQlJsdz09IiwibWFjIjoiMmMzZTE5ODk5ZWViODdhOTgxNDhiNTc0NTQ2ODQ3ZTY0ZmFhYTIyNjFlNGUxYjFhYmRmODEzYjJmNDIwYzA5NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1949, 1, N'bank.net.br/70', N'2398570', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia2lKSHEyMjlhNmE3WUdBUk5peDhzQT09IiwibWFjIjoiYjRiYTRjNzJhNmZiY2YwODE5ODkwNmI3MjdkMTU4NGNiMmRhYTM3YWRkM2NmZTRlNmU4MWQ2YjI2ZjgyYmFlYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1950, 1, N'ort.gob/71', N'2398571', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiZGhnVW5BeUlpNDd6ZXh5QlJ3YjhhUT09IiwibWFjIjoiNTYxYWE4OGIxMjJlZGViYmMxNmVmZmZhY2Q1ZWE1MmMzOTc0MDU2NzdkYzBjMTBkZjdkNTM1Y2RmNGFkMTQ1ZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1951, 1, N'ort.net.uk/72', N'2398572', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUFhXdE9TZExZRnVRcDdkZExvUnM4dz09IiwibWFjIjoiOTczYWEyMGQ5NmM3ZjU0ZGE1ZjMwZDFlZDkxNTYwMGI0OTA2YjBlYTRiZmJhZTQxNTc3OWM5ODBhZjgxNGYyOSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1952, 2, N'amazon.net.uy/73', N'2398573', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicEo3T1pIMXNvVS82WUJtMkZuUGp6YS9jc2ZaMmx2QlRVbjh5ZVh3NlhxST0iLCJtYWMiOiJkYzlhYjA3YjhhMWMyZjIxNGVmNWYzY2M0YjY2OWY2Zjg1MGVmODNiMjU0NzkzYmI3N2E2Y2FkMDBiNGJmYTAwIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1953, 2, N'amazon.co.uy/74', N'2398574', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiMjBkNm1Mb0toME9JcXhURzdjcmtjZmlIQ1FxZUtXMXpEZmlZVDduL3hkVT0iLCJtYWMiOiI4MWVjOGQ0MzE2NjQ1ODkyYzY0YzUxYmU1Nzk2ODE5YjU4Nzg4ODgwNGMxMGU0YmFjYzdiZjVkNTM5ZmM3NzMzIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1954, 2, N'amazon.co.uy/75', N'2398575', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiMjNmMTRFZmlkVitwbUJOZ3hiMkJKdz09IiwibWFjIjoiNzA2ZmJiNjgwZTNhM2U5NjY0NGJhZDMyNGRlYTNkMThlZjg5YzVmNzdkODA2MTZlMTY0MGIxYzQ0MDMxMzdkZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1955, 2, N'amazon.edu.uk/76', N'2398576', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicHlodnl5NlBLWVZUeFdielJwVC9lcXlqSTltSEhRTHJOWFVLVzRqeXA3ST0iLCJtYWMiOiJmY2Y2MzkzNzU2M2U1N2Y3M2NiYWU1Y2Y4Y2FmNWM1MTkzYzdhZWU2NDc0ODQ3N2M3ZTFkMzYzN2YzZDFmMTJmIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1956, 2, N'ort.edu.br/77', N'2398577', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVmJlbCtpTzJNaEl5S1hhZ1hHRnBXdz09IiwibWFjIjoiYTU0OGQwZWNjNmQ0N2U0NWZiOWM3MmUzZGFjMTFlOTMyZTgwMzU4YzhiYmFmYjE4ZmUwYTBlM2EwNGZkNDUyYiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1957, 3, N'facebook.edu/78', N'2398578', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic0ZNSzFtbjJDYWpPNkZicHlqMjM3d3lJM2dRdmEwSmlxRjJ4Uk8vYUQybz0iLCJtYWMiOiJhYjczNjEyMjBiMzc1NjMyMWRiMjlmODY5YmRkOTVhNjA2ODg1NDY4YmFhODY5Y2VhZTRlMzY4ZDJmYTcxODNjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1958, 3, N'twitter.net.eu/79', N'2398579', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiSFpaT3ZVK3FCVnJIMEdYRkhTRUFWai9oWGpianYvVkttWHRzMm9HOElYWT0iLCJtYWMiOiI1ZGViZDc4ODNmODVhZjlmNzE2OGNkNjMxMTRjMGFlMjMyZGRkZDJhMTI5ZTk2MTRmYjdkOTY1NzFlMzJkMGY4In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1959, 4, N'amazon.net.br/80', N'2398580', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiakpxdkc0TDFvcXlKelJrd1lQOW1qUT09IiwibWFjIjoiMjFkZTVlYzkwM2MzNjBiOTNmMTdlODhkNzU0OGVhZDhlYmI3NTY2OGIxMzU4NDU2YmEyOTc2MWQ4MzAyOGYzOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1960, 4, N'ort.co.br/81', N'2398581', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoieGhyRlpNU1lqTG9KY0swcUpKN0NuampRamVSUWt0YStiMllJRmhXd2xQbz0iLCJtYWMiOiIzZjI1NjY4NzM1N2EzMmFlMzBjYjFlOTFiZDE3Yjg2ZmZiYzczODYxMzI5NzQ2ZDVkYTUxZGVmYzhlMjdjMjQ1In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1961, 0, N'ort.gob.br/82', N'2398582', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUlVBZHNJaUsvL0RSOUJCaHpGQlJsdz09IiwibWFjIjoiMmMzZTE5ODk5ZWViODdhOTgxNDhiNTc0NTQ2ODQ3ZTY0ZmFhYTIyNjFlNGUxYjFhYmRmODEzYjJmNDIwYzA5NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1962, 0, N'facebook.com/83', N'2398583', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiREFvYXZCUk1DNzNMemxiMHoyalJkZz09IiwibWFjIjoiMjU5YTQ0NTFiNDhkMmJhYzA1ZTRmNDY0NDg4ZjQ4YTgyMzBkYTNhNzdlYTUwYTRiZmY4MzZkNDFmMGQzNDlhOSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1963, 1, N'twitter.com.eu/84', N'2398584', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia2lKSHEyMjlhNmE3WUdBUk5peDhzQT09IiwibWFjIjoiYjRiYTRjNzJhNmZiY2YwODE5ODkwNmI3MjdkMTU4NGNiMmRhYTM3YWRkM2NmZTRlNmU4MWQ2YjI2ZjgyYmFlYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1964, 1, N'twitter.gob.br/85', N'2398585', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoidGZSbzEwRFBzNGUrMXBGT2JzMUJZdz09IiwibWFjIjoiN2JhYzBjNmRlYjgyZjc4Yzc2Yjg1Yzc2YjBjNzliNDZmZTg3MmQzNDM3MjU3ODNkYzQ5NmQwNDEzYmExZjI2OSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1965, 2, N'ort.net.uk/86', N'2398586', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicEo3T1pIMXNvVS82WUJtMkZuUGp6YS9jc2ZaMmx2QlRVbjh5ZVh3NlhxST0iLCJtYWMiOiJkYzlhYjA3YjhhMWMyZjIxNGVmNWYzY2M0YjY2OWY2Zjg1MGVmODNiMjU0NzkzYmI3N2E2Y2FkMDBiNGJmYTAwIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1966, 2, N'bank.net/87', N'2398587', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoianlYYVpidnR3T2tzZTlLVmdCb3RRdz09IiwibWFjIjoiZGI1OTYzNTQzZWViZjdiNjk5ZGM1ZTRlOTIzYzYwMDQwYmVlMTlkYWE4YmQ1Y2FhOWUwNzlkZjQzMTE3MGJiOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1967, 2, N'ort.com/88', N'2398588', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicHlodnl5NlBLWVZUeFdielJwVC9lcXlqSTltSEhRTHJOWFVLVzRqeXA3ST0iLCJtYWMiOiJmY2Y2MzkzNzU2M2U1N2Y3M2NiYWU1Y2Y4Y2FmNWM1MTkzYzdhZWU2NDc0ODQ3N2M3ZTFkMzYzN2YzZDFmMTJmIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1968, 2, N'amazon.edu.uk/89', N'2398589', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVmJlbCtpTzJNaEl5S1hhZ1hHRnBXdz09IiwibWFjIjoiYTU0OGQwZWNjNmQ0N2U0NWZiOWM3MmUzZGFjMTFlOTMyZTgwMzU4YzhiYmFmYjE4ZmUwYTBlM2EwNGZkNDUyYiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1969, 3, N'facebook.co.br/90', N'2398590', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic0ZNSzFtbjJDYWpPNkZicHlqMjM3d3lJM2dRdmEwSmlxRjJ4Uk8vYUQybz0iLCJtYWMiOiJhYjczNjEyMjBiMzc1NjMyMWRiMjlmODY5YmRkOTVhNjA2ODg1NDY4YmFhODY5Y2VhZTRlMzY4ZDJmYTcxODNjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1970, 4, N'facebook.gob.uk/91', N'2398591', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiakpxdkc0TDFvcXlKelJrd1lQOW1qUT09IiwibWFjIjoiMjFkZTVlYzkwM2MzNjBiOTNmMTdlODhkNzU0OGVhZDhlYmI3NTY2OGIxMzU4NDU2YmEyOTc2MWQ4MzAyOGYzOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1971, 4, N'ort.edu/92', N'2398592', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiRkcrWlV1cDh2NFppcGpubXVZUXlHZz09IiwibWFjIjoiMmVhYzY2NTcwOGNlZmZlODQwMjE1OGNlOTczMzBmZmY5MzgxMTljMzNjNDQwMGE2ZjBlOTg0NjNmMzY0MjEwMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1972, 0, N'facebook.net.br/93', N'2398593', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUlVBZHNJaUsvL0RSOUJCaHpGQlJsdz09IiwibWFjIjoiMmMzZTE5ODk5ZWViODdhOTgxNDhiNTc0NTQ2ODQ3ZTY0ZmFhYTIyNjFlNGUxYjFhYmRmODEzYjJmNDIwYzA5NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1973, 0, N'amazon.edu.uy/94', N'2398594', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiREFvYXZCUk1DNzNMemxiMHoyalJkZz09IiwibWFjIjoiMjU5YTQ0NTFiNDhkMmJhYzA1ZTRmNDY0NDg4ZjQ4YTgyMzBkYTNhNzdlYTUwYTRiZmY4MzZkNDFmMGQzNDlhOSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1974, 1, N'twitter.gob.uk/95', N'2398595', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia2lKSHEyMjlhNmE3WUdBUk5peDhzQT09IiwibWFjIjoiYjRiYTRjNzJhNmZiY2YwODE5ODkwNmI3MjdkMTU4NGNiMmRhYTM3YWRkM2NmZTRlNmU4MWQ2YjI2ZjgyYmFlYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1975, 1, N'twitter.com.uy/96', N'2398596', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiQm9pUm5UV0ZmS21TNUxZTFdJTE02dz09IiwibWFjIjoiM2FiYzFiOTJkZDNmN2ZmNDE1OTE5MTg1ZGVhODBlNWQ1ODNjZjU5YmJkYzlmNzAzMThlZTRhNzliM2ZkM2IyMSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1976, 2, N'ort.edu.uk/97', N'2398597', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVmJlbCtpTzJNaEl5S1hhZ1hHRnBXdz09IiwibWFjIjoiYTU0OGQwZWNjNmQ0N2U0NWZiOWM3MmUzZGFjMTFlOTMyZTgwMzU4YzhiYmFmYjE4ZmUwYTBlM2EwNGZkNDUyYiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1977, 3, N'amazon.edu.uk/98', N'2398598', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic0ZNSzFtbjJDYWpPNkZicHlqMjM3d3lJM2dRdmEwSmlxRjJ4Uk8vYUQybz0iLCJtYWMiOiJhYjczNjEyMjBiMzc1NjMyMWRiMjlmODY5YmRkOTVhNjA2ODg1NDY4YmFhODY5Y2VhZTRlMzY4ZDJmYTcxODNjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1978, 4, N'facebook.edu.eu/99', N'2398599', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiakpxdkc0TDFvcXlKelJrd1lQOW1qUT09IiwibWFjIjoiMjFkZTVlYzkwM2MzNjBiOTNmMTdlODhkNzU0OGVhZDhlYmI3NTY2OGIxMzU4NDU2YmEyOTc2MWQ4MzAyOGYzOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1979, 4, N'bank.com.br/100', N'23985100', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiRkcrWlV1cDh2NFppcGpubXVZUXlHZz09IiwibWFjIjoiMmVhYzY2NTcwOGNlZmZlODQwMjE1OGNlOTczMzBmZmY5MzgxMTljMzNjNDQwMGE2ZjBlOTg0NjNmMzY0MjEwMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1985, 0, N'amazon.edu.eu/106', N'23985106', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWmRZNGJyMHNRaWdRMkZGWHhKbmlmUT09IiwibWFjIjoiNGRmYWJjZjI2MjRjNDUyNDIyNzhiMDZjYzgyYjA3NGNmZTg4OWY0ZDcwZGFjOGZiYTE0Njc0NjFmODU4NzUxMSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1986, 2, N'bank.gob.br/107', N'23985107', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibCtpWENIRWJ3YzBCaHAxVTRVSXYzSjdOK2F5VlJTdlQzSHVHUFRzWUp4TT0iLCJtYWMiOiJmM2IxNzlkNmEwZTY2ZDY5OGMzZTlmOWUxN2E2ODdlYTE2ZWQwOWEwOTRiN2YyMzljNGEzYmYyZWNhZTczYjA2In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1987, 1, N'bank.gob.eu/108', N'23985108', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiK3FiNGNZNkRLZEFlK2dhQlFOZ3doUT09IiwibWFjIjoiMTU2MTFjYzBiYjQzZGE0NWMwZjM4OTBlNjJiM2ZjZmNmMjdhYTQ2MDEyMjBmNzNjMmFjZTgwZTk3ZmE1MTA4NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1988, 2, N'facebook.net.eu/109', N'23985109', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiRnFveExseUFPOC9PcDRweE1zOXBJRHlDWStBMUNWOUpVT0diRGo4NElBOD0iLCJtYWMiOiJjMGE4OGI0MzFlZTYwODAyMjMzNzNiMjI0OGQ3ODIzYmY0MzdiM2IyYTY5YjNkMzQ0ZTU4YTc3OTVjZTZkZTllIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1989, 4, N'facebook.co.uk/110', N'23985110', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiL1NJeDZOQWh3aWFxYXV6UVBZeG15QT09IiwibWFjIjoiMzc2Y2FhZGE0MjA4ZDBkZGIxNWJjY2EyYzVmYjU5MzM5ZTY1YTFhM2MxOTc5NjUyNjRlZTRjNjQ5ZmY1ZjA1ZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1990, 4, N'ort.co.uy/111', N'23985111', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiOTZRbEd0M0dUYStMU056SkVhQTVmK214N09xMFZZSE9JWlM3TWlQeFFCST0iLCJtYWMiOiI3OWQyYTliNmI0NzVkYzdhZjg3MTZmMDYwMjlhMTg0YjQ3MzZiMDk5NDc0YWY0ZjkzNmJkYWI3Nzg4OGEzY2MyIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1991, 1, N'twitter.gob.eu/112', N'23985112', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWjFrSVV5R1RQNGh2OVNqZkZwNGd3QT09IiwibWFjIjoiNzhlMDJmMjMwMjY0NzY2NDE3NWQyZDljM2ZjMTQwMzQwMDY1OTcwYjVhODYzMDJlNWI4NGUzMzdiY2E1YTYxZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1992, 2, N'facebook.gob.br/113', N'23985113', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic3E2aGNobGl5d3N4UnQ1aEhESHRWclR2ZXMvZFptN2twQWN2L29hZy9yRT0iLCJtYWMiOiJkNzVkODIzNjk2N2EwMDAxZDRmZTcwODZlN2MzY2RhODVkOWUyNTg2ZWRmZjNhMTY5YTk1YTkwMjQ2NzBmZWI4In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1993, 1, N'facebook.gob.uy/114', N'23985114', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiekwzZmxIV2p4YmhpKzcrTy83Q2daUT09IiwibWFjIjoiOWU0Y2U1N2NlNjcyOTYzMGYwYTBlOWY3Y2M2MTU3ZGFiMzY3NjI1ODhlYWVhMjBlY2E4NGU0MWVkNWUyODIzOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1994, 1, N'bank.co.uy/115', N'23985115', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVlN3MC84K1hKd2JNcWx3UGpHdlV1QT09IiwibWFjIjoiZGQyNDk4YjM1YTdkM2VhMTY0NTk0ZTlmZWQ4ZTJmYThmNmEyYWMwMTY1NGFlYTIwNTQ5OTQ2YjYzNDVkMTgwOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1995, 1, N'ort.net.uk/116', N'23985116', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibmdrWlU3ZGhwTzdGeGhNT2RJUFBidz09IiwibWFjIjoiMzA4YzkxODhlYjdhNDY0OTRmMWQxNWMwM2Q2ODAxODFmY2EzMGM1ZTdjMTA3OGRjZTg4NjBhZGYzNDFhNjIyMyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1996, 0, N'amazon.com.uy/117', N'23985117', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWmthbUtOcVVyNFhBRnZJRkhxOVg1UT09IiwibWFjIjoiYmVjMWMxYzYwYTE5N2RmYjY3OTRmNDczYjljNjBjZTFiMmRjYjE5YTE4N2VlZGI0ZWUzYmNjNGQ5ODI5ZTc1YyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1997, 1, N'twitter.net.br/118', N'23985118', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWjFrSVV5R1RQNGh2OVNqZkZwNGd3QT09IiwibWFjIjoiNzhlMDJmMjMwMjY0NzY2NDE3NWQyZDljM2ZjMTQwMzQwMDY1OTcwYjVhODYzMDJlNWI4NGUzMzdiY2E1YTYxZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1998, 2, N'bank.net.uy/119', N'23985119', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibW9pa09NKzh1RDM4T3gwSjdZZitBUT09IiwibWFjIjoiMmM4ZTM2NjM4YjIzYTg0ZGI3ZWJjYWMwN2RmYWU0ZWRiODgxY2Q2NmQ1OTI1NWM2ODVjN2ZlNzNkYTcwNjA0NiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (1999, 4, N'bank.edu.br/120', N'23985120', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoidU5OYVNsMmR0RUdkSyt5VDcrdm9aQT09IiwibWFjIjoiYzIyMzc1YWE1ZDczY2EzNzYyNGQwYjdhYzJhZTg0NzNhZjIwZjFjNWRmNjUyZTlhODBiZTAwNmM3MTg5MzZkMiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2000, 4, N'ort.gob.uk/121', N'23985121', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTGQwNk0xV21BT0gxeTVrMEJYQ3BuZ2lCUUZJRHU1Y0FIREJLa2VBOE93TT0iLCJtYWMiOiIyYTIzNTg5MGFlMmQyNjU5ZWRiNTM3YmFjNjU3MmNmYThiMjE0NmNiYWVkZmQ5ZWJkNzhmNDJjMzBlNzZkYmFjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2001, 0, N'facebook.edu.br/122', N'23985122', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiZXRSdGduTUtBWTFZeDRnMFQ5NUNNZz09IiwibWFjIjoiYjczMzIxN2I5N2E0OTEwMDIwMzRiOWE2MTEyMTk2MjhmMTYwNTgxNTQ5YmZhYmZlOWYwZDdjNWQyYmI0MWY3YSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2002, 0, N'twitter.edu.eu/123', N'23985123', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicE1Md1VGanppSUVpUGNSdGxZV3dHZz09IiwibWFjIjoiOTI5YjBjZThmYWQxM2ViOWUxNWIyN2NmN2MwZGUyZTUwODA1OWZlMjZhNGZlOWY0ZjkzZTRhZDYwZmE3NTE0YSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2003, 0, N'amazon.net/124', N'23985124', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiZjNvWnVWd1ZqckYwSlNqeDMvTVAyQT09IiwibWFjIjoiY2Y5MjgyMzNjZWU2OGQxNzMyYTJiODAzNzE2MDU3MTRiODQ1MTdhOGE1YzI1ZjllYjFiZjNjMzEyOTVhMjNhMyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2004, 1, N'facebook.co.uy/125', N'23985125', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicVFQbHBkTUtNSldUWEI4R3kwcW5Udz09IiwibWFjIjoiNDVjZWE0Yjc5ZDFhY2I2NWU4MzdkZjEyZjlhYTJjN2UzZTlhNTM0ZDgyOGM5OGE5ODFiNTBiODA1ZmQ2OWU5MiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2005, 1, N'amazon.com.eu/126', N'23985126', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicXhCeHZWcHVYNXFyV1hNdksyOXFWdz09IiwibWFjIjoiMGRiMTM3MTljM2YxZmNiYThmYWViN2M4YjZjMGM1NzAzMGQ3ZGJjOGIzMTZjMjc0YjE2YmU4Y2FkNWYyOWY0NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2006, 1, N'facebook.com.br/127', N'23985127', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiajdmeUlXdTVuT3Fodkd5MzhhaXROUT09IiwibWFjIjoiODIxNzU4Y2JkOWQ1NDEzMDc2OTBkOGJjZDc3NDQ2MTJiOTgwYWMyMGRiMTI5MGE4ZWZlNWM2ZTRlNmJlZjg1OSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2007, 2, N'bank.co/128', N'23985128', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWlZHOEVRdmRGQloxcTFzUi9USGZwaGx1UTBnRDRIbS9HbjdNZ1FJSTdYYz0iLCJtYWMiOiJhM2Q3MDc1ZDA3NmZjODIxZWE2Mjk0ZTM5NGFiNDU1NTgwNDMzMDJiZjM3ZjY2ZjBhYzk1M2MyMDZiNTU0MDgxIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2008, 2, N'bank.net.uy/129', N'23985129', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUHp1c2xBWktVZUFrVzFFdERBWEhWOVNLZnBnYld6cG5OZ0xYcW9wR3NMaz0iLCJtYWMiOiJhNTk1OGIxOTQyMmQ0OTNiNjdjY2Y1MTE5ZWEyNjhmNjdlZGQyZjU4MjI3MjE2NzQ3YjczNzVmODA2ZDBhYTYxIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2009, 3, N'facebook.edu.br/130', N'23985130', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiRHlTRVp6VnBXKzAwT1VZbk1WSWcwaHdmN3AvK0srR1EzOG5Lc3lJcmZZMD0iLCJtYWMiOiIzZDQ4ZmY0MTYxOWQyZjk4OTg5OTNmMzdhMDg5NjZlYmU1MzFkMjFmYTk0MDhhNWZhMTM2YWVjYzg1OTRkZDhiIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2010, 3, N'ort.co.uk/131', N'23985131', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiSnF0RzhiUXI0OWN3L3RJV3ZId0k5S2w4OGo1ZkNrTmo4Y05SVzdaSXM3ST0iLCJtYWMiOiIwNGM5MGNjZDgxNzg5YzhmZGQ5YmIyZDAxNzY1YWEwZGYyMDIzMDBkNmJhNDEwM2NiNDlmZGY2ZjQ2N2Q1OWI5In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2011, 4, N'twitter.edu.eu/132', N'23985132', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoidU5OYVNsMmR0RUdkSyt5VDcrdm9aQT09IiwibWFjIjoiYzIyMzc1YWE1ZDczY2EzNzYyNGQwYjdhYzJhZTg0NzNhZjIwZjFjNWRmNjUyZTlhODBiZTAwNmM3MTg5MzZkMiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2012, 4, N'amazon.co.br/133', N'23985133', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiNDlORGh0NFpMVnFUcC9TUmVFeUlMUT09IiwibWFjIjoiODVmNGRjYjk3MDBiMGFiNDVmYTY5MTk1MWFlYTVhMDk4ZGYzM2RiMGE4MDFmZmM2ODk0MmQzMmJhNTFjMDZlMSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2013, 1, N'facebook.net.eu/134', N'23985134', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWjFrSVV5R1RQNGh2OVNqZkZwNGd3QT09IiwibWFjIjoiNzhlMDJmMjMwMjY0NzY2NDE3NWQyZDljM2ZjMTQwMzQwMDY1OTcwYjVhODYzMDJlNWI4NGUzMzdiY2E1YTYxZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2014, 1, N'amazon.co.br/135', N'23985135', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiSU1EZHJrWjFRdnhCNVBIRnFmbnJ3UT09IiwibWFjIjoiMGIyOTRlMWI1Nzk0YjEyZDBiNzk5NTNkYzU3MGMyMTJhNGYyNmQwYTg3MDE4YWVlN2YyNTJhYzY0OWEyMTY1MCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2015, 1, N'twitter.edu.uy/136', N'23985136', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiekwzZmxIV2p4YmhpKzcrTy83Q2daUT09IiwibWFjIjoiOWU0Y2U1N2NlNjcyOTYzMGYwYTBlOWY3Y2M2MTU3ZGFiMzY3NjI1ODhlYWVhMjBlY2E4NGU0MWVkNWUyODIzOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2016, 1, N'ort.edu.uk/137', N'23985137', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVlN3MC84K1hKd2JNcWx3UGpHdlV1QT09IiwibWFjIjoiZGQyNDk4YjM1YTdkM2VhMTY0NTk0ZTlmZWQ4ZTJmYThmNmEyYWMwMTY1NGFlYTIwNTQ5OTQ2YjYzNDVkMTgwOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2017, 1, N'ort.gob.br/138', N'23985138', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiSEc0UzVyUVVjczlMaUljaWtKOTNOUT09IiwibWFjIjoiNzJmMTg1OTMwYzVjYTVmNTIwYzNkNGRmOGIwZGNhN2I5NWFjMzE4NzdmNTA0OGM3NDJiNzM5MGQxYzM4Y2ZmOCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2018, 1, N'amazon.edu.uk/139', N'23985139', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicjBUUDBCcEpWQlg1R1hIQjhJcFQ4UT09IiwibWFjIjoiNGQ0YTQ2YzU1MjgyMzdkMDVjNmYxZjFjNWQ2OTZiMWJhZTQ1ODZjNWIzNzg1MTJjZmEyMGZhMGM1YzA2YTczNSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2023, 2, N'twitter.gob.eu/144', N'23985144', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoid1l0OWJiWkpESEVvYjBJdlJyM1NQUT09IiwibWFjIjoiMmJiMjBiM2JiNzgwZjdkOTExODgyZjI0Y2U3NTk5OGYzMTc1NmY3MDUzOWNmZGIwMmU5YzQ0MTQ3ZThlNTNiMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2024, 3, N'amazon.net/145', N'23985145', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicGltNENaTjZrajI4VkNTc1RXOWZPRU51RXBsOEtQaVFqOFhVd0FjK2lBQT0iLCJtYWMiOiI1ZTYxMjBjNTBiMDA5ZTNiZjQxYTVhMDE0NmZiNzM1ZTUxM2JjNGE2ZDllOGMxOThmYTgzMDY3MjFkMDMxMWJjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2025, 4, N'amazon.co.br/146', N'23985146', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUXlhbi85eGpDY29HSSsrVjhxNUJKQT09IiwibWFjIjoiMTUxZWU0NDkzMjIyZTkzZTI3MDM5YTIzYmE0MDE1NWY2OThiZDZiMzZmZTgwMzJjMjRmM2ZmNDlhMjgyYzJkMyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2026, 4, N'amazon.net.uk/147', N'23985147', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiQkNKbDB3Mjg2UElsaEVONjhWMGc2dz09IiwibWFjIjoiNzUzOTQ0NDQyYmI2OTMzMjEyZTU1OGI0MTA1NmFhYzhiMjRmYmYyODg2MzFiNWFkNTAwODU3N2Y1ZjE0MmU1NCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2027, 4, N'facebook.gob.uk/148', N'23985148', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoidWx3Uzd0bW1ZVlVIV1prZTJqc09QQT09IiwibWFjIjoiMzliNWE3MDM0MjQ2YmMwZDI4N2U3MWVjOTRkMTA0NjIyMGMyYTMxN2Q4N2Q1YWViYjNmNWFmOTRlNGVkMWU3OCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2028, 4, N'twitter.co.br/149', N'23985149', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia283TWl2dnpoQTMvVHhYVjgrK0RySVlPTGlmZWVLVUxQMFNoZnJsWnZJYz0iLCJtYWMiOiJmM2JiMTkwOTgxZDM1Mzc3YzZmMmU1NmRjNDg4NDE2MWU5ZGM2ZjQ1NzY0MmVkZDcxZmE0ZWYyMzBhYWVkM2E0In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2029, 1, N'twitter.com.uk/150', N'23985150', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicXFUR3VETW4rUm1JcXhRUUg1YzBoZz09IiwibWFjIjoiOTgzNWJkNjljMjBmZGZmZjA4NTc2MTk0Y2MzOTNlMWY3ZmNhYjdiMmVmMzg5M2NhNTFjZGJlNGU2N2I3MWY3OSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2030, 2, N'twitter.co.uy/151', N'23985151', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoid1l0OWJiWkpESEVvYjBJdlJyM1NQUT09IiwibWFjIjoiMmJiMjBiM2JiNzgwZjdkOTExODgyZjI0Y2U3NTk5OGYzMTc1NmY3MDUzOWNmZGIwMmU5YzQ0MTQ3ZThlNTNiMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2031, 3, N'facebook.com/152', N'23985152', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiNlQxMDFKeWZTTlhxaHl3VWFhNTlMZVA1cjRPNVRYU0xiWExjeUdKcVdmYz0iLCJtYWMiOiI5M2NlOThjMTcwY2YwMmQ2MTIyZTcxYTAzZDIxYjQ2NDg4OWIyYmJhODQ5MmJjYTE1ODk2NGI1MTg1YjA1NjQwIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2032, 3, N'amazon.net.eu/153', N'23985153', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiYkhFMXdqc0ZHY1Jvd1MvdW9wU3laT1RvMzlyNEk4c0FqaXJqTGZWN09xQT0iLCJtYWMiOiI1NmRkYmY5Nzg1NWExNDYxYzE0M2I4MjQ3MzBmOWVkMmE1MmIxZTc5MjM2ODRiZTNhYjgyYTY2YmFiYjdjODNkIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2033, 3, N'facebook.co.uy/154', N'23985154', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicGltNENaTjZrajI4VkNTc1RXOWZPRU51RXBsOEtQaVFqOFhVd0FjK2lBQT0iLCJtYWMiOiI1ZTYxMjBjNTBiMDA5ZTNiZjQxYTVhMDE0NmZiNzM1ZTUxM2JjNGE2ZDllOGMxOThmYTgzMDY3MjFkMDMxMWJjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2034, 4, N'facebook.net/155', N'23985155', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUXlhbi85eGpDY29HSSsrVjhxNUJKQT09IiwibWFjIjoiMTUxZWU0NDkzMjIyZTkzZTI3MDM5YTIzYmE0MDE1NWY2OThiZDZiMzZmZTgwMzJjMjRmM2ZmNDlhMjgyYzJkMyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2035, 4, N'ort.com.uy/156', N'23985156', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiQkNKbDB3Mjg2UElsaEVONjhWMGc2dz09IiwibWFjIjoiNzUzOTQ0NDQyYmI2OTMzMjEyZTU1OGI0MTA1NmFhYzhiMjRmYmYyODg2MzFiNWFkNTAwODU3N2Y1ZjE0MmU1NCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2036, 4, N'amazon.net.uy/157', N'23985157', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoidWx3Uzd0bW1ZVlVIV1prZTJqc09QQT09IiwibWFjIjoiMzliNWE3MDM0MjQ2YmMwZDI4N2U3MWVjOTRkMTA0NjIyMGMyYTMxN2Q4N2Q1YWViYjNmNWFmOTRlNGVkMWU3OCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2037, 4, N'facebook.co.uy/158', N'23985158', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia283TWl2dnpoQTMvVHhYVjgrK0RySVlPTGlmZWVLVUxQMFNoZnJsWnZJYz0iLCJtYWMiOiJmM2JiMTkwOTgxZDM1Mzc3YzZmMmU1NmRjNDg4NDE2MWU5ZGM2ZjQ1NzY0MmVkZDcxZmE0ZWYyMzBhYWVkM2E0In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2038, 3, N'facebook.gob.br/159', N'23985159', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicGltNENaTjZrajI4VkNTc1RXOWZPRU51RXBsOEtQaVFqOFhVd0FjK2lBQT0iLCJtYWMiOiI1ZTYxMjBjNTBiMDA5ZTNiZjQxYTVhMDE0NmZiNzM1ZTUxM2JjNGE2ZDllOGMxOThmYTgzMDY3MjFkMDMxMWJjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2039, 4, N'amazon.net/160', N'23985160', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUXlhbi85eGpDY29HSSsrVjhxNUJKQT09IiwibWFjIjoiMTUxZWU0NDkzMjIyZTkzZTI3MDM5YTIzYmE0MDE1NWY2OThiZDZiMzZmZTgwMzJjMjRmM2ZmNDlhMjgyYzJkMyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2040, 4, N'bank.com.uk/161', N'23985161', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiQkNKbDB3Mjg2UElsaEVONjhWMGc2dz09IiwibWFjIjoiNzUzOTQ0NDQyYmI2OTMzMjEyZTU1OGI0MTA1NmFhYzhiMjRmYmYyODg2MzFiNWFkNTAwODU3N2Y1ZjE0MmU1NCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2041, 4, N'ort.edu.br/162', N'23985162', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoidWx3Uzd0bW1ZVlVIV1prZTJqc09QQT09IiwibWFjIjoiMzliNWE3MDM0MjQ2YmMwZDI4N2U3MWVjOTRkMTA0NjIyMGMyYTMxN2Q4N2Q1YWViYjNmNWFmOTRlNGVkMWU3OCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2042, 4, N'ort.com.uy/163', N'23985163', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia283TWl2dnpoQTMvVHhYVjgrK0RySVlPTGlmZWVLVUxQMFNoZnJsWnZJYz0iLCJtYWMiOiJmM2JiMTkwOTgxZDM1Mzc3YzZmMmU1NmRjNDg4NDE2MWU5ZGM2ZjQ1NzY0MmVkZDcxZmE0ZWYyMzBhYWVkM2E0In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2043, 3, N'amazon.co.br/164', N'23985164', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiNlQxMDFKeWZTTlhxaHl3VWFhNTlMZVA1cjRPNVRYU0xiWExjeUdKcVdmYz0iLCJtYWMiOiI5M2NlOThjMTcwY2YwMmQ2MTIyZTcxYTAzZDIxYjQ2NDg4OWIyYmJhODQ5MmJjYTE1ODk2NGI1MTg1YjA1NjQwIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2044, 3, N'amazon.net.eu/165', N'23985165', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiYkhFMXdqc0ZHY1Jvd1MvdW9wU3laT1RvMzlyNEk4c0FqaXJqTGZWN09xQT0iLCJtYWMiOiI1NmRkYmY5Nzg1NWExNDYxYzE0M2I4MjQ3MzBmOWVkMmE1MmIxZTc5MjM2ODRiZTNhYjgyYTY2YmFiYjdjODNkIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2045, 3, N'twitter.co.br/166', N'23985166', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiY1RJSlJqbXM2a21McUxuM1IzalNVZEY5amlBKzJkdmgrVGl3enFVWlA1dz0iLCJtYWMiOiIzZGEyMDQwMzZhMDFlZTFmMmZkMjE4MWUyYmRkZDBiZmQ1NGU0OWRjYmE3YWQ5NTlhMTExMjEzNGI1M2QwOGFhIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2046, 3, N'ort.net.uy/167', N'23985167', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWDRyQlZwUGd4bGhvWk5DUlJsaEhINHp6eEx2MVVoWW5PKzNEaW1TNm9hOD0iLCJtYWMiOiI4NGMwMWZiNjI3OGMzYzBjOTg1N2M3YTZiODdjODk4YjY2MWNhYmViMDI1NDZhNjgyMThhMjRkZTliZjFhMWU2In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2047, 3, N'bank.gob.uk/168', N'23985168', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoicGltNENaTjZrajI4VkNTc1RXOWZPRU51RXBsOEtQaVFqOFhVd0FjK2lBQT0iLCJtYWMiOiI1ZTYxMjBjNTBiMDA5ZTNiZjQxYTVhMDE0NmZiNzM1ZTUxM2JjNGE2ZDllOGMxOThmYTgzMDY3MjFkMDMxMWJjIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2048, 2, N'amazon.gob/169', N'23985169', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoid1l0OWJiWkpESEVvYjBJdlJyM1NQUT09IiwibWFjIjoiMmJiMjBiM2JiNzgwZjdkOTExODgyZjI0Y2U3NTk5OGYzMTc1NmY3MDUzOWNmZGIwMmU5YzQ0MTQ3ZThlNTNiMCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2049, 4, N'bank.com.uk/170', N'23985170', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUXlhbi85eGpDY29HSSsrVjhxNUJKQT09IiwibWFjIjoiMTUxZWU0NDkzMjIyZTkzZTI3MDM5YTIzYmE0MDE1NWY2OThiZDZiMzZmZTgwMzJjMjRmM2ZmNDlhMjgyYzJkMyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2050, 4, N'amazon.gob.uy/171', N'23985171', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiQkNKbDB3Mjg2UElsaEVONjhWMGc2dz09IiwibWFjIjoiNzUzOTQ0NDQyYmI2OTMzMjEyZTU1OGI0MTA1NmFhYzhiMjRmYmYyODg2MzFiNWFkNTAwODU3N2Y1ZjE0MmU1NCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2051, 4, N'amazon.gob/172', N'23985172', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoidWx3Uzd0bW1ZVlVIV1prZTJqc09QQT09IiwibWFjIjoiMzliNWE3MDM0MjQ2YmMwZDI4N2U3MWVjOTRkMTA0NjIyMGMyYTMxN2Q4N2Q1YWViYjNmNWFmOTRlNGVkMWU3OCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2052, 4, N'facebook.com.eu/173', N'23985173', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia283TWl2dnpoQTMvVHhYVjgrK0RySVlPTGlmZWVLVUxQMFNoZnJsWnZJYz0iLCJtYWMiOiJmM2JiMTkwOTgxZDM1Mzc3YzZmMmU1NmRjNDg4NDE2MWU5ZGM2ZjQ1NzY0MmVkZDcxZmE0ZWYyMzBhYWVkM2E0In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2057, 0, N'facebook.edu.eu/178', N'23985178', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia0xEZ2VZV0t2dVFrK3VoZGNrR2ZJQT09IiwibWFjIjoiY2Y1ZjA0NjVjOTFkOTU4MDlmNWE0NWYxZmFiZjJiMTFhZDFkODdhNzFiZTBlMDUzMzFhNWMwZGQ1MjliY2U2NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2058, 0, N'bank.com.uy/179', N'23985179', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiV1FGSmFPcE9ic1ZJSE81TVFCVGNZdz09IiwibWFjIjoiYTZjMTRkMzc4NmY1OThmZTBhZTgyODA0NDNhMjQ1NzEzMzBlMGNmNTAwMDkwNWM5NmJhOWEzOWE3ZDRiMDJmOSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2059, 0, N'amazon.co.eu/180', N'23985180', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiN1h4ZFh3VGNTeUYwY0wyMjRISUtPdz09IiwibWFjIjoiNjY1N2NhOWY3ODEwOTZmYjY1ZjkxMGUwNzUxZThmYmVmYWE4MGRmOWQzYzczOTkxYTY0NTE5NGQyNjFkM2MxMiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2060, 0, N'bank.net.uy/181', N'23985181', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVytscURpV05oNGh5ZGF0ZE5US0FCUT09IiwibWFjIjoiMTZhMzBkZGE4MWU0NGU5NDIzNmZiYjBkNGUyMDgyYzlhMDIzOTY5NTc1NDcyY2JhYTYxYjgxY2QwMGVhMWU0MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2061, 0, N'ort.gob/182', N'23985182', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVytscURpV05oNGh5ZGF0ZE5US0FCUT09IiwibWFjIjoiMTZhMzBkZGE4MWU0NGU5NDIzNmZiYjBkNGUyMDgyYzlhMDIzOTY5NTc1NDcyY2JhYTYxYjgxY2QwMGVhMWU0MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2062, 1, N'amazon.edu.br/183', N'23985183', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWFhldnZ2dzJydjJ5VTdON21IS3Fpdz09IiwibWFjIjoiYTg2ODg4MzNlY2Q1NThjNmI4ODllYzFlYjNhMzk2NWIzZGViMzllMWU3ZTMzNTdkYjEwOGI3ZGJkM2ViY2QyYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2063, 1, N'facebook.edu/184', N'23985184', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibnNsV0pqUzJzaHhMeWhvTWhzc1pmdz09IiwibWFjIjoiNjE4MjZiNjg1Y2Q3MTUxOTdjMWQ1ZGQwYzM2YjRmMDgzMTkzNjVlMjcyNGExYTA0NGZiYmQwNjJlMWY0ZGNjZiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2064, 1, N'facebook.edu.uy/185', N'23985185', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic1lGb1BiTVk2ckw0Sk9TVmZXejNtUT09IiwibWFjIjoiNTMxMzgwYTkwYWU1MTEzMTEyMmMyNTIxYzY5MDNjZWQ0OGQzNzgzYWI2ZjQyYzAzZjI3NWU5MzkwMmRmODg2NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2065, 1, N'amazon.co.eu/186', N'23985186', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVnA0bWNKTlh2VjMwRGUwRUl3MHFzQT09IiwibWFjIjoiZDM2ZTlmYzM3MWFmYWE1MTIwYjBjYjI5Mzk0OWNjYWMyNGRkYTg3Y2UwNWM3MDdiOWE5YjkxMTliOTVkNTBkZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2066, 1, N'bank.net.eu/187', N'23985187', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTkxLNHlNcWxsVndzYzgwa21QbitvZz09IiwibWFjIjoiM2NmZWM3MjBlYTdiMjZhNDkxZWZkOWY5YzQyZDIyYWRjOTIxZjNlYWY1OTIyZTNkZmEwNjNhN2M5Nzk0MjkwZiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2067, 2, N'amazon.net.uk/188', N'23985188', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTmRxL3FjdHVjRVdTVTRQNFRzUGtvWUZ1NjdyUUNVbzE4K2ZyRlV6amdQUT0iLCJtYWMiOiIyYTVhZGNiZDdkZWQ2ODdjYjkyMDQ1YjUwOThkMGEyZDQxNDU1ODk0MTI5ZmY2OGM3MjA0NTU4ZmQ2YzBkYmQxIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2068, 0, N'bank.edu.uy/189', N'23985189', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia0xEZ2VZV0t2dVFrK3VoZGNrR2ZJQT09IiwibWFjIjoiY2Y1ZjA0NjVjOTFkOTU4MDlmNWE0NWYxZmFiZjJiMTFhZDFkODdhNzFiZTBlMDUzMzFhNWMwZGQ1MjliY2U2NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2069, 0, N'twitter.gob.uy/190', N'23985190', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiV1FGSmFPcE9ic1ZJSE81TVFCVGNZdz09IiwibWFjIjoiYTZjMTRkMzc4NmY1OThmZTBhZTgyODA0NDNhMjQ1NzEzMzBlMGNmNTAwMDkwNWM5NmJhOWEzOWE3ZDRiMDJmOSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2070, 0, N'facebook.co.uy/191', N'23985191', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiN1h4ZFh3VGNTeUYwY0wyMjRISUtPdz09IiwibWFjIjoiNjY1N2NhOWY3ODEwOTZmYjY1ZjkxMGUwNzUxZThmYmVmYWE4MGRmOWQzYzczOTkxYTY0NTE5NGQyNjFkM2MxMiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2071, 0, N'twitter.edu.eu/192', N'23985192', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVytscURpV05oNGh5ZGF0ZE5US0FCUT09IiwibWFjIjoiMTZhMzBkZGE4MWU0NGU5NDIzNmZiYjBkNGUyMDgyYzlhMDIzOTY5NTc1NDcyY2JhYTYxYjgxY2QwMGVhMWU0MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2072, 0, N'ort.com.eu/193', N'23985193', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVytscURpV05oNGh5ZGF0ZE5US0FCUT09IiwibWFjIjoiMTZhMzBkZGE4MWU0NGU5NDIzNmZiYjBkNGUyMDgyYzlhMDIzOTY5NTc1NDcyY2JhYTYxYjgxY2QwMGVhMWU0MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2073, 0, N'amazon.edu.br/194', N'23985194', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVytscURpV05oNGh5ZGF0ZE5US0FCUT09IiwibWFjIjoiMTZhMzBkZGE4MWU0NGU5NDIzNmZiYjBkNGUyMDgyYzlhMDIzOTY5NTc1NDcyY2JhYTYxYjgxY2QwMGVhMWU0MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2074, 0, N'facebook.co.uk/195', N'23985195', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVytscURpV05oNGh5ZGF0ZE5US0FCUT09IiwibWFjIjoiMTZhMzBkZGE4MWU0NGU5NDIzNmZiYjBkNGUyMDgyYzlhMDIzOTY5NTc1NDcyY2JhYTYxYjgxY2QwMGVhMWU0MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2075, 1, N'amazon.net.eu/196', N'23985196', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWFhldnZ2dzJydjJ5VTdON21IS3Fpdz09IiwibWFjIjoiYTg2ODg4MzNlY2Q1NThjNmI4ODllYzFlYjNhMzk2NWIzZGViMzllMWU3ZTMzNTdkYjEwOGI3ZGJkM2ViY2QyYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2076, 1, N'amazon.co.br/197', N'23985197', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTkxLNHlNcWxsVndzYzgwa21QbitvZz09IiwibWFjIjoiM2NmZWM3MjBlYTdiMjZhNDkxZWZkOWY5YzQyZDIyYWRjOTIxZjNlYWY1OTIyZTNkZmEwNjNhN2M5Nzk0MjkwZiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2077, 2, N'bank.gob.uy/198', N'23985198', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTmRxL3FjdHVjRVdTVTRQNFRzUGtvWUZ1NjdyUUNVbzE4K2ZyRlV6amdQUT0iLCJtYWMiOiIyYTVhZGNiZDdkZWQ2ODdjYjkyMDQ1YjUwOThkMGEyZDQxNDU1ODk0MTI5ZmY2OGM3MjA0NTU4ZmQ2YzBkYmQxIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2078, 2, N'bank.gob/199', N'23985199', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibXBNaHBtUHYvZnEyOUNwajFuZG1OZz09IiwibWFjIjoiODg0ZWZjYTBkOWI3Yjk1NjlmMjQwMzdmNzc5MjM4OWVmNDY3OWFmYTFkYmM2ZjZlYTQ2ZTZiY2E4OTZmYWQ3NyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2079, 0, N'ort.gob/200', N'23985200', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoia0xEZ2VZV0t2dVFrK3VoZGNrR2ZJQT09IiwibWFjIjoiY2Y1ZjA0NjVjOTFkOTU4MDlmNWE0NWYxZmFiZjJiMTFhZDFkODdhNzFiZTBlMDUzMzFhNWMwZGQ1MjliY2U2NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2080, 0, N'twitter.edu.eu/201', N'23985201', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiV1FGSmFPcE9ic1ZJSE81TVFCVGNZdz09IiwibWFjIjoiYTZjMTRkMzc4NmY1OThmZTBhZTgyODA0NDNhMjQ1NzEzMzBlMGNmNTAwMDkwNWM5NmJhOWEzOWE3ZDRiMDJmOSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2081, 1, N'facebook.com.uy/202', N'23985202', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiWFhldnZ2dzJydjJ5VTdON21IS3Fpdz09IiwibWFjIjoiYTg2ODg4MzNlY2Q1NThjNmI4ODllYzFlYjNhMzk2NWIzZGViMzllMWU3ZTMzNTdkYjEwOGI3ZGJkM2ViY2QyYSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2082, 1, N'facebook.net.eu/203', N'23985203', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibnNsV0pqUzJzaHhMeWhvTWhzc1pmdz09IiwibWFjIjoiNjE4MjZiNjg1Y2Q3MTUxOTdjMWQ1ZGQwYzM2YjRmMDgzMTkzNjVlMjcyNGExYTA0NGZiYmQwNjJlMWY0ZGNjZiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2083, 1, N'twitter.co.uy/204', N'23985204', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoic1lGb1BiTVk2ckw0Sk9TVmZXejNtUT09IiwibWFjIjoiNTMxMzgwYTkwYWU1MTEzMTEyMmMyNTIxYzY5MDNjZWQ0OGQzNzgzYWI2ZjQyYzAzZjI3NWU5MzkwMmRmODg2NSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2084, 1, N'ort.co.uy/205', N'23985205', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiVnA0bWNKTlh2VjMwRGUwRUl3MHFzQT09IiwibWFjIjoiZDM2ZTlmYzM3MWFmYWE1MTIwYjBjYjI5Mzk0OWNjYWMyNGRkYTg3Y2UwNWM3MDdiOWE5YjkxMTliOTVkNTBkZCJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2085, 1, N'twitter.co/206', N'23985206', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTkxLNHlNcWxsVndzYzgwa21QbitvZz09IiwibWFjIjoiM2NmZWM3MjBlYTdiMjZhNDkxZWZkOWY5YzQyZDIyYWRjOTIxZjNlYWY1OTIyZTNkZmEwNjNhN2M5Nzk0MjkwZiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2086, 2, N'twitter.gob/207', N'23985207', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiTmRxL3FjdHVjRVdTVTRQNFRzUGtvWUZ1NjdyUUNVbzE4K2ZyRlV6amdQUT0iLCJtYWMiOiIyYTVhZGNiZDdkZWQ2ODdjYjkyMDQ1YjUwOThkMGEyZDQxNDU1ODk0MTI5ZmY2OGM3MjA0NTU4ZmQ2YzBkYmQxIn0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2087, 2, N'twitter.net/208', N'23985208', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibXBNaHBtUHYvZnEyOUNwajFuZG1OZz09IiwibWFjIjoiODg0ZWZjYTBkOWI3Yjk1NjlmMjQwMzdmNzc5MjM4OWVmNDY3OWFmYTFkYmM2ZjZlYTQ2ZTZiY2E4OTZmYWQ3NyJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2088, 3, N'facebook.com.br/209', N'23985209', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiUGlZR2orQ1FNRWZkZThEZDY0OWtYZ211SkFvaytnRWRlYXlCckVkdnNRcz0iLCJtYWMiOiIwMjVlZGJmZWY3MmJjMDQ1ZmFlMmIwYzhmMWZhMDhiZWZhZGRjYWY3NDc4ZDhlZDIwZWU4YWY3NzI2MDM2ZDE3In0=')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2089, 4, N'twitter.net.br/210', N'23985210', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoibjBwZHhiYmNXS3drbWZob25xYjJ2UT09IiwibWFjIjoiNjBiOTdlOTdjMDRlNGE3ODg1MDUxNDQ2MDE1NTY3NGMxOThjY2NmZGQ5Y2M3OWE4NTc1NWE2YjQzZWI3OGI0MSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2090, 4, N'amazon.co.br/211', N'23985211', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiMEN3VjBzRllyQjdpQXNwOFhnQTFKZz09IiwibWFjIjoiYzlhYTgxZDhiYzMzOGNiOTA0NzQyNTUzMzJlNDA1YThiMWNiMzc4Y2Y3ZDk3NDRlMzEwYzY3NDMwZWMxOTU4YiJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2091, 4, N'ort.edu/212', N'23985212', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiNGtPQ3lXRTYvTFNYL3R5YWIraElZQT09IiwibWFjIjoiZmQwOWY4NDc3YzZkNTg3ZjkyMDI2ZTRmOGEwY2EwODU5MDdmODA3YzM2MTkyNDljYzhjMDhhZmVmZmMyY2Q0OSJ9')
GO
INSERT [dbo].[Passwords] ([Id], [PasswordStrength], [Site], [Username], [LastModification], [EncryptedPass]) VALUES (2092, 4, N'amazon.co.uk/213', N'23985213', CAST(N'2021-04-05T00:00:00.000' AS DateTime), N'eyJpdiI6IjdidEduWm0xQktscDJ2Q2J0WnNzRXc9PSIsInZhbHVlIjoiMzdFVGJpSDE3NWE2Ykd1czhLQUtWOGVpdmN6WVhNY1NoMUsySGtGL09KND0iLCJtYWMiOiJjYjAzNjgzZWQ0OThhYzU1MGE5YjNkYThkODU2Mzc4ZmZmNjAyODJhZDQxOWRiZWE3NWFmNTJlOWQwMzA3NTRmIn0=')
GO
INSERT [dbo].[SharedPasswordUser] ([PasswordId], [UserSharedWithName]) VALUES (1889, N'Laura')
GO
INSERT [dbo].[SharedPasswordUser] ([PasswordId], [UserSharedWithName]) VALUES (1890, N'Laura')
GO
INSERT [dbo].[SharedPasswordUser] ([PasswordId], [UserSharedWithName]) VALUES (1889, N'Mario')
GO
INSERT [dbo].[SharedPasswordUser] ([PasswordId], [UserSharedWithName]) VALUES (1890, N'Mario')
GO
INSERT [dbo].[SharedPasswordUser] ([PasswordId], [UserSharedWithName]) VALUES (1892, N'Mario')
GO
INSERT [dbo].[SharedPasswordUser] ([PasswordId], [UserSharedWithName]) VALUES (1889, N'Pablo')
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (22, 1889)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (22, 1892)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (22, 1894)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (22, 1896)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (23, 1898)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (23, 1899)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (24, 1907)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (23, 1917)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (23, 1921)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (24, 1925)
GO
INSERT [dbo].[DataBreachReportItems] ([DataBreachReport_Id], [Item_Id]) VALUES (24, 2097)
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1926, N'MasterCard Black', N'Master', N'4730055481735642', N'471', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1927, N'MasterCard Black', N'Master', N'4876522860222738', N'482', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1928, N'MasterCard Black', N'Master', N'4941602408020571', N'490', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1929, N'MasterCard Black', N'Master', N'5047158607811274', N'507', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1980, N'MasterCard Black', N'Master', N'1019909212962216', N'1013', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1981, N'MasterCard Black', N'Master', N'1022352561978787', N'1026', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1982, N'MasterCard Black', N'Master', N'1037993577359241', N'1038', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1983, N'MasterCard Black', N'Master', N'1043578614405160', N'1042', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (1984, N'MasterCard Black', N'Master', N'1051459618974225', N'1053', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2019, N'MasterCard Black', N'Master', N'1406065142598499', N'1404', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2020, N'MasterCard Black', N'Master', N'1418915378170979', N'1418', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2021, N'MasterCard Black', N'Master', N'1428988147121848', N'1428', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2022, N'MasterCard Black', N'Master', N'1432205931588171', N'1438', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2053, N'MasterCard Black', N'Master', N'1745642984755170', N'1743', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2054, N'MasterCard Black', N'Master', N'1758855393168914', N'1752', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2055, N'MasterCard Black', N'Master', N'1761872437273558', N'1760', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2056, N'MasterCard Black', N'Master', N'1777115722723359', N'1773', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2093, N'MasterCard Black', N'Master', N'2145444106219543', N'2147', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2094, N'MasterCard Black', N'Master', N'2159417089847576', N'2152', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2095, N'MasterCard Black', N'Master', N'2167368630231529', N'2166', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2096, N'MasterCard Black', N'Master', N'2175679878971855', N'2177', N'02/30')
GO
INSERT [dbo].[CreditCards] ([Id], [Name], [Type], [Number], [SecureCode], [ExpirationDate]) VALUES (2097, N'Visa Premium', N'Visa', N'2354232313003498', N'1234', N'02/30')
GO
SET IDENTITY_INSERT [dbo].[DataBreachReportEntries] ON 
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (127, N'23985023', 22)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (128, N'14893470823575754543', 22)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (129, N'#stsrtARSRT2332', 22)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (130, N'2398345023', 22)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (131, N'mySecretPassword', 22)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (132, N'qwerty', 22)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (133, N'-d4502-s--ss-3', 23)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (134, N'babushcka', 23)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (135, N'148sdfsdarst#$#@$5754543', 23)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (136, N'aaaaaa', 23)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (137, N'abcst333de8762', 23)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (138, N'qwerty123', 23)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (139, N'Chsau344(!&*($$^&#^@#&', 24)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (140, N'nethisean4', 24)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (141, N'2354232313003498', 24)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (142, N'2352331413003498', 24)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (143, N'1254231413003498', 24)
GO
INSERT [dbo].[DataBreachReportEntries] ([Id], [Value], [DataBreachReport_Id]) VALUES (144, N'sdsdsd123', 24)
GO
SET IDENTITY_INSERT [dbo].[DataBreachReportEntries] OFF
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202106111904294_CleanMigration-Merge', N'Repository.Migrations.Configuration', 0x1F8B0800000000000400ED5DDB6E24B7117D0F907F68F4936DAC35232936124163433B920C212B69A1D13AC9D380EAA6460DF765DCCD596B10F8CBF2904FCA2F84EC2BEF4DF66566641B0B2CA4265924AB0E8BC562B1F4BFFFFCF7FCFBD728743EC3340B9278E61E1F4D5D07C65EE207F16AE66ED0F3D77F75BFFFEECF7F3ABFF2A357E7C7AADE29A9875BC6D9CC7D41687D369964DE0B8C407614055E9A64C9333AF2926802FC6472329DFE6D727C3C8198848B6939CEF9C326464104F35FF0AFF324F6E01A6D40789BF830CCCAEFB864915375EE4004B335F0E0CC7D80EB240B50926E5DE7220C001EC10286CFAE03E2384100E1F19D7DCAE002A549BC5AACF107103E6ED710D77B066106CB719F35D54DA7303D215398340D2B52DE2643496449F0F8B4E4C9846FDE89B36ECD33CCB52BCC5DB425B3CE393773E700C155CE32BEB3B37998928A33F7FE290C56003336488E979717C74797B85E101F556DDF397C8D773520A647F9BF77CE7C13A24D0A6731DCA01484EF9C8F1BDCC8FB3BDC3E263FC178166FC2901E2A1E2C2E633EE04F1FD3640D53B47D80CFE5046E7CD799B0ED267CC3BA19D5A698DA4D8C4E4F5CE70E770E9E4258238162C3024F0BFE006398E2E9FA1F0142308D090D98F352E89DEB8BFC5FF586A187578FEBDC82D70F305EA117BCAEBE719DEBE015FAD58772009FE200AF35DC06A51B281920D7E91DF84C0480C7CB758F019FBACE030CF3C2EC255817ABA216DEB2A8719D26D143125288C80B968B64937A640289ACF411A42B88D8D19C4F1A9069A157746C0F3BD26EAF90BB0519C64021585BE8D16D95A038190614D2AE3F822CD3748D7F1C179025800298F58165053C392C2BD07682E53C857E80E620F53BE9C4BAF5701075DE830C9612233CBA413072FB289D71F045BADB79A7779BE8890045AD60BF1DA3DB05F4B0D8E69880A6EBD3317ABE7A5D07690EC64B8C794DEF03B0DB78CDE0A180F72904DE0B31C252D465E5F034FEB02A347DD1B2273F3F06511FA55CF01DFA44B3C8F5322F9D25D7A451D4FA9A8241D1525D6661E86682A1A9DC5B84AEEACA9AD19775DAC75D55B41DB1D242137AE0B7446985F681F6B7DCF20DA8C31227ED06DC162F9E325CEAA15297FD0697F95D82A0CE5A3BF9666AA4E52D8DB3AD148F447ACBA6468343A640C01F5B3AD8EAC8C9F22BA2FE281F457FE413EBF997A49B6958B5DDA761588D016329074C8D2DD29C2F9C276192DA9B4681D62C19C70C24928DF761F47EC087AADBC40F9E03AF74D1D86ECAC206E6A5DB75AE2CF67B505BBC007C96F947404022597F15589674BD66254A8A853529ABD36B75F25B1DD9923B79B6A484FE3048357DFD08C28D6EF599C2D54CEE9B48A29339B575935D8760D538772D50F009056180B031275789032AF04FB10FD3708BB9450B8AE5F42D2447DC72B20F100B3567F6CC9D0A4261AADEA7205EC1BAF6B1BEF6BF601826BFD4B54FF4B53F04AB17F4430A615CB738D5B7B804E94F6C83BF88D22EE44A7FBCC8B2C40B728171364AB1F9B33D5EC5BEA3F562369B5D63C8DC6249056B2C1B0CB599FB95300D15D1DA07D5102DEC1196E0B1CBAFEEFBF812861041E7C22B2E05E620F3802FF126E2AE190E51DCD03389B5D554F351186E9C4161C120B9AD67C0F5631E0B7633D542416214F69CE1C18B5FB639AB66A4DDA945E3D08659BA0DBE856D5F7506448BA742355653B745336CD1E965CE1943AF871D50FB30A97285180F58F08B983366B82561364409371596E268ECD52AA8163FCE4888B35162D3A323530D5D986CF32446D890AE77FF4A13DC8218AC607AF99E5480AF324731EEBFB4CC32A963A7E8600191E442A9B11785FD46600C4B85CC5A46A0E0464B639EB73242A2EC5A88968E558150A1082C47547B3A5BC755AE048E3E256C81F3D55D1D55477A99C72FFA3663AD9E132BE389299D0ADB149D52CABC526167673073CE1526CE5C637F195860D4884B1468262DB7B98C98D775E62A792B6CB1166BCC7EB6638B57EADB10A7DB6A6519DB59562CD059552330A3EDE647E48B8D05D6C506A32629D1BC1ACE195A5D6DD2188289B54236609FD436B3B3CE8663196F546928D7731C9E7D2A0D64607859985EC3716D288D55B9C46AFBAA2E3B9F141191E587F3892274F2FC16ACD741BCA24229CB2FCEA288A39C7FBDB00F348C0A1A132F93C41BD6A3AD7B42498AED40AE14778D477A1DA419220C7C02C46D37F723A19AD29A54184555B782C1284AB0B28EAA26E4E7CAF35685971EA936F68697D7787A118C513E53286EC692A60E8969052148255EDC79126EA258E509D6B52E2281E8F6B2B8B50231DCD879E64C04EE08673396DF46D22856404741C856B78110E4CD542CA443F66846AAC300DBA915973B22B5E2FBC10847B5619BAD922690AEC33AA91B0BFDAB79BBABA5A2A25044C0D1148A2F166328C3D9985194DFCCA9D0D1693425FABB39353EE28CA6C8970D8FDC16BCDD64E4E7FBE72F28E011D47ED90173E2F5F988602B223B1839179F76CE428A73B593D79E7955D39D2D57319481A625965A2C9F808779F1C59C42138E405369BE9A5312E30B688A62A9C5B266030D9855CD161DCC76241AE11D712E38E3ECF1DE4E621CD88B3A782CCD3B9090D4A7D74EA22AFC93FDE5A5A0338ED0CAE8089A40F969F76263CF96D2A351E5D1D51E7ECA3AA6071C723A56441B32A763911F5646794E4A6799E757481531DB31968E01C3319A60463D1CDE0B602D4CCE492D152657C7C422923049EA82EEC8A49A8C1DB70CC6F5F684A7598554791FA11DF0CA132E0ADE86E0A477075A639BA9A932AB557E4C85512CB964E8C8BE8AE200CB5173713100F61AA2B6F0EB2DF3B62B1223C3866FD466C0182E73B33B958EE010880F8012B34B9AAECA8028951D6B04F5DD8F192EEAEA9D4C5A130E73B745870C06EEFAE96DEC098AEB2B33F1CB37F9B6E3A7092F0F78F3D7DECBED44E84E9E7CC40FF2A8AE9B8C84CED7A1E416336FC78E70A5C757A90F84F5D51E7785775E5EA7B5A74811EED78A2AAE8359F039F0C9DDDA628BA712E5303C5AFC1CCEC3001F419B0AB7200E9E61868A2076F7647A7CC2655B399CCC27932CF399C7169AF427ACD076F02423205C6D7D7461FB1A1E344FA0E2CF20F5B04D24A41BE9F0B46A29A6AD68C80B117C37B10F5F67EEBF730267CECD3F971C8D77CE7D8AB174E64C9D5F85375AC3BC48572417A987F6EBFE137F4805D4CA011565FAB95845F98B08BC7E391447258F0BDFEC32A19FD52AC430A5A94A5FD1AA3C45DCE00D9607D5945D1ABF8BA5AA3765DE2CC8E8140D3EFE1975790DBA3F89DA3CC7337A86F9DB902AF3CE51A9674DF485F4B864A73724242CF487F5A377C9230623316A5D4862F576674E3B0AE82EED78DAB4ECAD8AF949745CBB2C993D28E4AE3BBF994340B2ECE54E9A76A9EF7D4949D4513517BB6194CDC658CDCAC8AA9DE96493F9F7E3FA1866369DDE6C289A6CF632F989EDDB01929349299F0E947B4C4A7C3065A4882BFA0D8155959325EFBE47F295A140CAE756198AAE2A754A6763599A3A6588B370D724048D9B77270FC499BED98B7FEBA407780DC194D8C8209C2731C9B3158891281FD320F6823508E9F98ADE591B470A99554D962FB9846B1813CB9D9FA3499F062EEA9A3EC7E636660C9E98C14A7862620FF6B95C877C079DA46F250DB933DE58F2F2505D493F2DE124BB92F8C1AA895D0264D7EAC1182487A11A4C6337244F41334684D4D79D6088F10FC8066290E0A32BA63461E7C36B1D5D308EBDE7635F9892DDF81E8836DA279276AD9DACC16416E4B40350750829D2BC8D3DC4D431C2AE28AF300A0E0DDE260CAED84C62CB7AB8F80E00942D4ACFC80CFA1D80CF58F0FB029C26806F1F20933E6E7963CAAEB89EEB9B1DEB2DAB3BD59BA237A5EFFA1F31C52C5FC361F98D1A699DD07918C7C9E69E6749E4D4905B922CCDC50DD363B2545F0759EF8E6AE8D09D302E2DFABB01180F7A4FD3A62C30EE6E9787421D2E54F72E03A2C2D27BF1F61031847362703C70D1C695B61032EFF05293665DDC6A732E16D1C533D77F4AB0888B6B174D363ABE8F628F12E89701F112DAF26C4A3CD902A602D9E2B38CAC3C09184F56DC01852EC42AB2EE5A534D19657B94494651CF6410578A5C5EFC5058478D3002B658D671E1E160EB594E5F2160793593C99B0180D9CCC45541974A17065DC190CBB28EA83259375431D7C9B8393E6940344998448527BB04933D2F6F79676130B5C192785A0D54B285F26F77079A5A9F2C9DF6D21A6B2ABAB49946293915AF86E47688E4E5AD59324E81615A0D360C1BAA7C82666C903FF4EA25F35D4DDE302FA86D26D27664A8F674F9133C1DAB747B94FA79EFE8AC5343A8D3335C5B7D70982CBA1A3537EB701862CC3CCD8BE011583454FE557B9DD38B9D1DA6DEC18D22B3927A3A637A2E2D89692A64591C708F32F32BE8F6AD0E9E899E2CB2340286C9D12B3EDCC507FB4D4CA21F8BDF2E6116AC1A12E449720C3DE6485FD7B9899F93CAABC08DA8AAC2BF1C8408F878C95CA42878061EC2C51ECCB2FC6F77957FA4E92A7AC22A3FBEDFA0F506E129C3E82964340AF150E8FACF1311B3633EBF5F93DFB221A68087199080D1FBF8FD26089BBF8D752D89EE549020AE8FF285109125222F8556DB9AD25D121B122AD9577B6C1E61B40E31B1EC3E5E80CFB0CBD8B03AFC0057C0DB56EFAFD544DA05C1B2FDFC3200AB14445949A3698F7FC518F6A3D7EFFE0FCF28DEFF08840000, N'6.4.4')
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'202106111909587_Changes-CreditCard-SecureCode-Length', N'Repository.Migrations.Configuration', 0x1F8B0800000000000400ED5DDB6E24B7117D0F907F68F4936DAC3523EDDA48048D0DED483284ACA48546EB244F03AA9B1A35DC97493767AD41E02FCB433E29BF10B2AFBC37D99799D1DA58602135C9225975582C168BA5FFFDE7BF673FBE44A1F319A65990C433F7F868EA3A30F6123F88573377839EBEFD8BFBE30F7FFED3D9A51FBD383F57F5DE927AB8659CCDDC6784D6A79349E63DC308644751E0A549963CA1232F8926C04F2627D3E95F27C7C7138849B89896E39CDD6F62144430FF05FF3A4F620FAED1068437890FC3ACFC8E4B163955E71644305B030FCEDC7BB84EB20025E9D675CEC300E0112C60F8E43A208E1304101EDFE9A70C2E509AC4ABC51A7F00E1C3760D71BD271066B01CF76953DD740AD313328549D3B022E56D32944496048FDF963C99F0CD3B71D6AD7986B97689B98BB664D639E766EE1C20B8CA59C677763A0F535271E6DE3D86C10A60C606C9F1F2E2FCF8E802D70BE2A3AAED1B87AFF1A606C4F428FFF7C6996F42B449E12C861B9482F08DF371831B797F83DB87E41718CFE24D18D243C583C565CC07FCE9639AAC618AB6F7F0A99CC0B5EF3A13B6DD846F5837A3DA1453BB8ED1DB13D7B9C59D83C710D648A0D8B0C0D3823FC118A678BAFE4780104C634203E6BC147AE7FA22FF57BD61E8E1D5E33A37E0E5038C57E819AFABEF5CE72A78817EF5A11CC0A738C06B0DB741E9064A06C8757A0B3E1301E0F172DD63C0A7AE730FC3BC307B0ED6C5AAA885B72C6A5CA549749F841422F282E522D9A41E9940222B7D00E90A227634679306645AE8151DDBC38EB4DB2BE46E4086315008D6167A745B25284E860185B4EB8F20CB345DE31FC7056409A000667D6059014F0ECB0AB49D60394FA11FA03948FD4E3AB16E3D1C449DF72083A5C4088FAE118CDC3E4A671C7C91EE76DEE9ED267A2440512BD8EFC7E876013D2CB63926A0E9FADD183D5FBEAC833407E305C6BCA6F701D86DBC66F050C0FB1402EF99186129EAB272781A7F58159ABE68D9939F1F82A88F522EF80E7DA259E47A9997CE926BD2286A7D4DC1A068A92EB3307433C1D054EE2D42577565CDE8CB3AEDE3AE2ADA8E5869A1093DF05BA2B442FB40FB5B6EF906D461899376036E8BE78F192EF550A9CBBEC0657E9B20A8B3D64EBE9B1A69794BE36C2BC52391DEB2A9D1E0902910F0C7960EB63A72B2FC8AA83FCA47D11FF9C47AFE35E9661A566DF769185663C058CA0153638B34E70BE74998A4F6A651A0354BC631038964E37D18BD1FF0A1EA26F183A7C02B5D34B69BB2B08179E9769D2B8BFD1ED416CF009F65FE1E109048D65F0596255DAF59899262614DCAEAF45A9DFC5647B6E44E9E2D29A13F0C524D5F3F8370A35B7DA6703593FB2692E8644E6D5D6757215835CE5D0B147C424118206CCCC955E2800AFC53ECC334DC626ED18262397D03C911B79CEC3DC442CD993D73A7825098AA77298857B0AE7DACAFFD4F1886C9AF75ED137DED0FC1EA19FD944218D72DDEEA5B5C80F417B6C13B51DA855CE98FE7599678412E30CE4629367FB6C7CBD877B45ECC66B36B0C991B2CA9608D6583A13673BF11A6A1225AFBA01AA2853DC2123C76F9D57D175FC01022E89C7BC5A5C01C641EF025DE44DC35C3218A1B7A26B1B69A6A3E0AC38D33282C1824B7F50CB87ECC63C16EA65A28488CC29E333C78F1CB3667D58CB43BB5681CDA304BB7C1B7B0ED9BCE8068F154A8C66AEAB668862D3ABDCC3963E8F5B0036A1F2655AE10E3010B7E1173C60CB724CC8628E1A6C2521C8DBD5A05D5E2C7190971364A6C7A7464AAA10B936D9EC4081BD2F5EE5F69821B1083154C2FDE930AF045E628C6FD9796592675EC141D2C20925C2835F6A2B0DF088C61A99059CB0814DC6869CCF3564648945D0BD1D2B12A102A1481E5886A4F67EBB8CA95C0D1A7842D70BEBAABA3EA482FF3F845DF66ACD57362653C31A553619BA2534A99572AECEC0C66CEB9C2C4996BEC2F030B8C1A718902CDA4E5369711F3BACE5C256F852DD6628DD9CF766CF14A7D1BE2745BAD2C633BCB8A053AAB6A0466B4DDFC887CB1B1C0BAD860D424259A57C33943ABAB4D1A4330B156C806EC93DA6676D6D9702CE38D2A0DE57A8EC3B34FA5810C0C2F0BD36B38AE0DA5B12A97586D5FD56567932222B2FC703651844E9EDD80F53A8857542865F9C559147194F36F17F68186514163E2659278C37AB4754F2849B11DC895E2AEF148AF82344384818F80B8EDE67E2454535A930AA3A8EA563018450956D651D584FC5C79DEAAF0D223D5C6DEF0F20A4F2F8231CA670AC5CD58D2D42131AD2004A9C48B3B4FC24D14AB3CC1BAD6452410DD5E16B75620861B3BCF9C89C01DE16CC6F2DB481AC50AE82808D9EA361082BC998A8574C81ECD487518603BB5E27247A4567C3F18E1A8366CB355D204D27558277563A17F356F77B55454148A08389A42F1C5620C65381B338AF29B39153A3A8DA6447F37A7C6479CD114F9B2E191DB82B7EB8CFC7CF7F415053C82DAAF3B604EBC3E1F116C45640723E7E2D3CE594871AE76F2DA33AF6ABAB3E52A8632D0B4C4528BE513F0302FBE985368C211682ACD57734A627C014D512CB558D66CA001B3AAD9A283D98E4423BC23CE05679C3DDEDB498C037B51078FA579071292FAF4DA4954857FB2BFBC1474C6115A191D4113283FED5E6CECD9527A34AA3CBADAC34F59C7F480434EC78A6843E6742CF2C3CA28CF49E92CF3FC0AA922663BC6D23160384613CCA887C37B01AC85C939A9A5C2E4EA9858441226495DD01D995493B1E396C1B85E9FF034AB902AEF23B4035E79C245C1EB109CF4EE406B6C33355566B5CA8FA9308A25970C1DD957511C60396A2E2E06C05E43D4167EBD65DE76456264D8F08DDA0C18C3656E76A7D2111C02F10150627649D3551910A5B2638DA0BEFB31C3455DBD93496BC261EEB6E890C1C05D3FBD8E3D41717D65267EF926DF76FC34E1E5016FFEDA7BB99D08DDC9938FF8411ED5759D91D0F93A94DC62E6EDD811AEF4F82AF581B0BEDAE3AEF0CECAEBB4F61429C2FD5A51C575300B3E073EB95B5B6CF154A21C86478B7F85F330C047D0A6C20D88832798A12288DD3D991E9F70D9560E27F3C924CB7CE6B18526FD092BB41D3CC90808575B1F5DD8BE8607CD13A8F833483D6C1309E9463A3CAD5A8A692B1AF24204DF75ECC39799FBEF9CC0A973FD8F2547E38D7397622C9D3A53E737E18DD6302FD215C945EAA1FDB6FFC41F5201B5724045997E2E5651FE2A022F5F0FC551C9E3C257BB4CE867B50A314C69AAD257B42A4F11377883E541356597C6EF62A9EA4D99570B323A45838F7F465D5E83EE4FA236CFF18C9E617E195265DE392AF5AC89BE901E97ECF486848485FEB07EF42E79C4602446AD0B49ACDEEECC694701DDA51D4F9B96BD55313F898E6B9725B30785DC75E73773084896BDDC49D32EF5BD2F29893AAAE662378CB2D918AB591959B5339D6C32FF7E5C1FC3CCA6D39B0D4593CD5E263FB17D3F40723229E57703E51E93121F4C1929E28ABE20B0AA72B2E4DDF748BE321448F9DC2A43D155A54EE96C2C4B53A70C7116EE9A84A071F3EEE48138D3377BF16F9DF400AF2198121B1984F3242679B6023112E5631AC45EB006213D5FD13B6BE34821B3AAC9F22517700D6362B9F37334E9D3C0455DD3E7D8DCC68CC1133358094F4CECC13E97EB90EFA093F4ADA42177C61B4B5E1EAA2BE9A7259C6457123F5835B14B80EC5A3D1883E430548369EC86E42968C68890FABA130C31FE01D9400C127C74C59426EC7C78ADA30BC6B1F77CEC0B53B21BDF03D146FB44D2AEB5933598CC829C7600AA0E21459AB7B187983A46D815E51546C1A1C1DB84C1159B496C590F17DF0180B245E9199941BF03F0190B7E5F80D304F0ED0364D2C72DAF4CD915D7737DB363BD6675A77A53F4AAF45DFF23A698E56B382CBF5223AD133A0FE338D9DCF32C899C1A724B92A5B9B8617A4896EAEB20EBDD510D1DBA13C6A5457F3700E341EF69DA9405C6DDEDF250A8C385EADE654054587A2F5E1F2286704E0C8E072EDAB8D21642E61D5E6AD2AC8B5B6DCEC522BA78E6FA8F09167171EDA2C946C7F751EC5102FD32205E425B9E4D89275BC054205B7C9691952701E3C98A3BA0D0855845D65D6BAA29A36C8F32C928EA990CE25291CB8B1F0AEBA81146C016CB3A2E3C1C6C3DCBE92B042CAF6632793300309B99B82AE852E9C2A02B187259D6115526EB862AE63A1937C7270D88260993A8F0649760B2E7E52DEF2C0CA63658124FAB814AB650FEEDEE4053EB93A5D35E5A634D459736D32825A7E2D590DC0E91BCBC354BC629304CABC1866143954FD08C0DF2875EBD64BEABC91BE605B5CD44DA8E0CD59E2E7F82A763956E8F523FEF1D9D756A08757A866BAB0F0E934597A3E6661D0E438C99A779113C028B86CABF6AAF737AB1B3C3D43BB8516456524F674CCFA525314D852C8B03EE51667E05DDBED5C133D193459646C030397AC587BBF860BF8949F463F1DB05CC825543823C498EA1C71CE9EB3AD7F153527915B8115555F8978310011F2F99F314054FC043B8D8835996FFEDAEF28F345D468F58E5C7771BB4DE203C65183D868C46211E0A5DFF79226276CC67776BF25B36C414F0300312307A17BFDF0461F3B7B1AE24D19D0A12C4F551BE1022B244E4A5D06A5B53BA4D62434225FB6A8FCD038CD6212696DDC50BF01976191B56871FE00A78DBEAFDB59A48BB2058B69F5D04609582282B6934EDF1AF18C37EF4F2C3FF018261B70F08840000, N'6.4.4')
GO
