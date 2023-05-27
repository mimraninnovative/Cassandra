# Cassandra in dotnet core using docker step by step guaid

1.docker pull cassandra
     docker images

2. **Run Container using Image**

   docker run -p 7000:7000 -p 7001:7001 -p 7199:7199 -p 9042:9042 -p 9160:9160 --name cassandra -d cassandra:latest
   
   Docker -ps
   ![image](https://github.com/mimraninnovative/Cassandra/assets/49446457/0d916ca2-9125-4604-afbe-f7d16c16ec38)

3.  use (container_id) in below  

     exec -it  6f9c6381c62e bash
     
4. **Create & describe Keyspace**

     create keyspace techframer with replication    ={'class':'SimpleStrategy','replication_factor':1};
     
     desc keyspaces

5. **Create Table**

    use techframer;
    
    CREATE TABLE student (student_id int PRIMARY KEY,student_name text,student_city text ,student_fees varint, student_phone varint);
    
    select * from student
    
     insert into student (student_id,student_fees,student_name)values(1,5000,'Ajeet');
     
  select * from student;
  
**  OUTPUT **

![image](https://github.com/mimraninnovative/Cassandra/assets/49446457/3ad96f42-42c4-4798-a8b0-214d4cf25701)

 ![image](https://github.com/mimraninnovative/Cassandra/assets/49446457/d83cef05-4aa1-44b2-9b8f-c6e536d26abc)
 
![image](https://github.com/mimraninnovative/Cassandra/assets/49446457/6cfdb1d3-d170-45b9-908e-ce38abe69b0a)

 
