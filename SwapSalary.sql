/* Write your T-SQL query statement below */
update salary
set sex = CASE
         WHEN sex = 'm' THEN 'f'
         WHEN sex = 'f' THEN 'm'
         end
