/* Write your T-SQL query statement below */
select FirstName, LastName, City, State from Person
left join Address on Person.PersonId = Address.PersonId
