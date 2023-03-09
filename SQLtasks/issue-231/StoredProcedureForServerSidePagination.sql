use RMs

CREATE PROC GetPageRecords
@tableName varchar(50) = '',
@PageNumber int = 1,
@PageSize int = 10,
@column varchar(30) = '',
@order varchar(30) = 'Asc'
as 
Begin
	if(@tableName!='')
		Begin
			if(@PageNumber < 0) and (@PageSize<0)
				Begin
					return Null;
				End
			Else 
				Begin
					Declare @query nvarchar(max);
					Declare @skip int = (@PageNumber -1) * @PageSize
					Set @query = N'select * from '+@tableName+' '
					if(@order != 'Asc')
						Begin
							set @query += ' '+@order+' '
						End
					if(@column != '')
						Begin
							set @query += ' Order by ' + @column+' '
						End
					Else
						Begin
							set @query += ' Order by  (select null)'+' OFFSET ('+cast(@skip as nvarchar(max))+')  ROWS FETCH NEXT ('+cast(@PageSize as nvarchar(max))+') ROWS ONLY'
						End
					Exec(@query)
				End
		End
	Else
		Begin
			return Null;
		End
end

Exec GetPageRecords @tableName='FoodItem',@PageNumber=3, @PageSize=20
Exec GetPageRecords @tableName='FoodItem', @PageSize=5,@PageNumber=3


