Create DATABASE GestionMatchDB
go
use GestionMatchDB

go

create table Stade (
Stade_ID int not null primary key,
Nom_Stade varchar(50),
Ville_Stade varchar(50)
)

go
create table Equipe (
Equipe_ID int not null primary key,
Nom_Equipe varchar(50) unique,
Ville varchar(50),
YearCreation date,
Entraineur_Nom varchar(30),
Logo varchar(50),
Stade_ID int foreign key references Stade (Stade_ID) ON Update cascade On DELETE set NULL
)
go

create table Joueur(
CIN_Joueur varchar(8) not null check(CIN_Joueur like '[A-Za-z][A-Za-z][0-9][0-9][0-9][0-9][0-9][0-9]') primary key,
Nom_Joueur varchar(50),
Prenom_Joueur varchar(50),
Position varchar(50),
Numero int,
Date_Naissance Date,
Equipe_ID int foreign key references Equipe(Equipe_ID) ON Update cascade On DELETE SET null
)
go


create table Referee(
CIN_Referee varchar(8) not null check(CIN_Referee like '[A-Za-z][A-Za-z][0-9][0-9][0-9][0-9][0-9][0-9]') primary key,
Nom varchar(50)
)

go
create table Matche (
Match_ID int not null primary key,
Date_Matche date,
Heure_Matche time,
Stade_ID int foreign key references Stade (Stade_ID)  ON Update cascade On DELETE SET NULL,
CIN_Referee varchar(8) foreign key references Referee (CIN_Referee)  ON Update cascade on DELETE SET NULL
)

go 

create table Match_Equipe(
Eq_Home_ID int foreign key references Equipe(Equipe_ID),
Eq_Away_ID int foreign key references Equipe(Equipe_ID),
Match_ID int foreign key references Matche(Match_ID) ON Update cascade On DELETE CASCADE,
primary key(Eq_Home_ID,Eq_Away_ID,Match_ID)
)


go

CREATE TABLE Chart_Filler(
	ChartX varchar(50) NOT NULL PRIMARY KEY,
	ChartY int NULL
)

go

create trigger TeamDeleter on Equipe after delete as 
begin
update Chart_Filler set ChartY = ChartY - 1 where ChartX='Teams'
end

go

create trigger TeamUpdater on Equipe after Insert as 
begin
update Chart_Filler set ChartY = ChartY + 1 where ChartX='Teams'
end

go

create trigger PlayerDeleter on Joueur after delete as 
begin
update Chart_Filler set ChartY = ChartY - 1 where ChartX='Players'
end

go

create trigger PlayerUpdater on Joueur after Insert as 
begin
update Chart_Filler set ChartY = ChartY + 1 where ChartX='Players'
end

go

create trigger GameDeleter on Matche after delete as 
begin
update Chart_Filler set ChartY = ChartY - 1 where ChartX='Games'
end

GO
create trigger GameUpdater on Matche after Insert as 
begin
update Chart_Filler set ChartY = ChartY + 1 where ChartX='Games'
end

go

create trigger RefereeDeleter on Referee after delete as 
begin
update Chart_Filler set ChartY = ChartY - 1 where ChartX='Referees'
end

GO

create trigger RefereeUpdater on Referee after Insert as 
begin
update Chart_Filler set ChartY = ChartY + 1 where ChartX='Referees'
end

go

create trigger StadiumDeleter on Stade after delete as 
begin
update Chart_Filler set ChartY = ChartY - 1 where ChartX='Stadiums'
end

GO
create trigger StadiumUpdater on Stade after Insert as 
begin
update Chart_Filler set ChartY = ChartY + 1 where ChartX='Stadiums'
end

go

insert into chart_filler values('Games',(select COUNT(*) from Matche ))
,('Teams',(select COUNT(*) from Equipe )),
('Players',(select COUNT(*) from Joueur )),
('Referees',(select COUNT(*) from Referee )),
('Stadiums',(select COUNT(*) from Stade ))
go

-----------Procedures-------------------------------------
create Proc Select_Games as begin
select m.Match_ID,eqh.Logo as 'lhome',eqh.Nom_Equipe as 'Home',eqa.Nom_Equipe as 'Away',eqa.Logo as 'laway',convert(varchar,m.Date_Matche) as Date_Matche , m.Heure_Matche,r.Nom, s.Nom_Stade from Match_Equipe me inner join Matche m on me.Match_ID=m.Match_ID inner join Equipe eqa on eqa.Equipe_ID=me.Eq_Away_ID inner join Equipe eqh on me.Eq_Home_ID=eqh.Equipe_ID inner join Referee r on m.CIN_Referee=r.CIN_Referee inner join Stade s on m.Stade_ID=s.Stade_ID order by m.Match_ID
end

go

create Proc Select_Search_Game (@search varchar(60))  as begin
select m.Match_ID,eqh.Logo as 'lhome',eqh.Nom_Equipe as 'Home',eqa.Nom_Equipe as 'Away',eqa.Logo as 'laway',convert(varchar,m.Date_Matche) as Date_Matche , m.Heure_Matche,r.Nom, s.Nom_Stade from Match_Equipe me inner join Matche m on me.Match_ID=m.Match_ID inner join Equipe eqa on eqa.Equipe_ID=me.Eq_Away_ID inner join Equipe eqh on me.Eq_Home_ID=eqh.Equipe_ID inner join Referee r on m.CIN_Referee=r.CIN_Referee inner join Stade s on m.Stade_ID=s.Stade_ID where eqh.Nom_Equipe like @search+'%' or eqa.Nom_Equipe like @search+'%' order by m.Match_ID
end

go

create proc Select_Players as begin
select j.CIN_Joueur as CIN,j.Nom_Joueur as LastName,j.Prenom_Joueur as FirstName,j.Position,j.Numero as Numbre,j.Date_Naissance as 'Date of birth',e.Nom_Equipe as Equipe from Joueur j inner join Equipe e on j.Equipe_ID=e.Equipe_ID
end

go

create proc Select_Search_Player (@search varchar(60)) as begin 
select j.CIN_Joueur as CIN,j.Nom_Joueur as LastName,j.Prenom_Joueur as FirstName,j.Position,j.Numero as Numbre,j.Date_Naissance as 'Date of birth',e.Nom_Equipe as Equipe from Joueur j inner join Equipe e on j.Equipe_ID=e.Equipe_ID where j.Nom_Joueur like @search + '%'
end

go

create proc Select_Teams as begin 
Select eq.Equipe_ID,eq.Logo,eq.Nom_Equipe as 'Team Name',eq.Ville as 'City',convert(varchar,eq.YearCreation) as 'Date Creation',eq.Entraineur_Nom as 'Coach',s.Nom_Stade as 'Stade' From Equipe eq inner join Stade s on eq.Stade_ID=s.Stade_ID order by eq.Equipe_ID
end

go

create proc Select_Search_Team(@search varchar(60)) as begin 
Select eq.Equipe_ID,eq.Logo,eq.Nom_Equipe as 'Team Name',eq.Ville as 'City',convert(varchar,eq.YearCreation) as 'Date Creation',eq.Entraineur_Nom as 'Coach',s.Nom_Stade as 'Stade' From Equipe eq inner join Stade s on eq.Stade_ID=s.Stade_ID where eq.Nom_Equipe like @search+'%'
end

go

create proc Random_Games as begin 
select m.Match_ID,eqh.Logo as'logoHome',eqh.Nom_Equipe,eqa.Nom_Equipe,eqa.Logo as 'logoAway',DATENAME(WEEKDAY,m.Date_Matche) + ','+ DATENAME(MONTH,m.Date_Matche) +' '+ CONVERT(varchar,DAY(m.Date_Matche)) + ','+CONVERT(varchar,Year(m.Date_Matche)) as'date', m.Heure_Matche, s.Nom_Stade from Match_Equipe me inner join Matche m on me.Match_ID=m.Match_ID inner join Equipe eqa on eqa.Equipe_ID=me.Eq_Away_ID inner join Equipe eqh on me.Eq_Home_ID=eqh.Equipe_ID inner join Stade s on m.Stade_ID=s.Stade_ID
end

go

create proc Random_Teams as begin 
select m.Logo,m.Nom_Equipe,YEAR(m.YearCreation) as 'YearCreation',m.Ville,m.Entraineur_Nom,s.Nom_Stade from Equipe m inner join Stade s on s.Stade_ID=m.Stade_ID
end

go
---------------------------------------------------User table ---------------------------------------------------------------------
create table User_Match(
Cin nvarchar(50) primary key not null,
Email nvarchar(70) not null unique,
Pass_Word nvarchar(50) not null,
FullName Nvarchar(50) not null
)
go

insert into User_Match values('BH124965','Alaa@gmail.com','123456789alaa','alaa qable'),('BH968412','badr@gmail.com','123456789badr','badr ouzomaki')
