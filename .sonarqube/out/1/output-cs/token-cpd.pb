Ó

S/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/AddressDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 

AddressDTO 
{		 
public

 
Guid

 
Id

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 

string 
City 
{ 
get 
; 
set !
;! "
}# $
public 

string 
Country 
{ 
get 
;  
set! $
;$ %
}& '
public 

string 
Region 
{ 
get 
; 
set  #
;# $
}% &
public 

string 

PostalCode 
{ 
get "
;" #
set$ '
;' (
}) *
public 

float 
Latitude 
{ 
get 
;  
set! $
;$ %
}& '
public 

float 
	Longitude 
{ 
get  
;  !
set" %
;% &
}' (
} 
} å	
T/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/AirplaneDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public		 

class		 
AirplaneDTO		 
{

 
public 
Guid 
Id 
{ 
get 
; 
set !
;! "
}# $
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
int 
Capacity 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Company 
{ 
get  #
;# $
set% (
;( )
}* +
public 
ICollection 
< 
FlightAirplanes *
>* +
?+ ,
flightAirplanes- <
{= >
get? B
;B C
setD G
;G H
}I J
} 
} ì

S/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/AirportDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 

AirportDTO 
{		 
public

	 
Guid

 
Id

 
{

 
get

 
;

 
set

 "
;

" #
}

$ %
public 

string 
Name 
{ 
get 
; 
set !
;! "
}# $
public 

string 
Code 
{ 
get 
; 
set !
;! "
}# $
public 

Guid 
	AddressId 
{ 
get 
;  
set! $
;$ %
}& '
public 


AddressDTO 
Address 
{ 
get  #
;# $
set% (
;( )
}* +
public 

List 
< 
FlightAirportsDTO !
>! "
FlightAirports# 1
{2 3
get4 7
;7 8
set9 <
;< =
}> ?
} 
} Ú
U/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/BaseModelDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 	
class
 
BaseModelDTO 
{ 
public		 

DateTime		 
?		 
	CreatedAt		 
{		  
get		! $
;		$ %
set		& )
;		) *
}		+ ,
public

 

string

 
?

 
	CreatedBy

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
public 

DateTime 
? 
LastModifiedAt #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 

string 
? 

ModifiedBy 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} Ä
Z/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/BookedRoomInfoDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
BookedRoomInfoDTO "
{ 
public 

string 
TotalAmount 
{ 
get  #
;# $
set% (
;( )
}* +
public		 

int		 

CountRooms		 
{		 
get		 
;		  
set		! $
;		$ %
}		& '
}

 
} ï

W/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/BookingroomDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
BookingRoomDTO 
{ 
public		 

Guid		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		  
public

 

string

 
Type

 
{

 
get

 
;

 
set

 !
;

! "
}

# $
public 

DateTime 
	StartDate 
{ 
get  #
;# $
set% (
;( )
}* +
public 

DateTime 
EndDate 
{ 
get !
;! "
set# &
;& '
}( )
public 

decimal 
TotalAmount 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 

ICollection 
< 
RoomDTO 
> 
Rooms  %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
} 
} ô
R/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/ClientDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
	ClientDTO 
: 
UserDTO $
{		 
public

 

Guid

 
ClientId

 
{

 
get

 
;

 
set

  #
;

# $
}

% &
public 

string 
PassportNumber  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

bool 
IsActive 
{ 
get 
; 
set  #
;# $
}% &
public 

Guid 
	AdresseId 
{ 
get 
;  
set! $
;$ %
}& '
public 

Guid 
UserId 
{ 
get 
; 
set !
;! "
}# $
public 


AddressDTO 
Address 
{ 
get  #
;# $
set% (
;( )
}* +
public 

UserDTO 
user 
{ 
get 
; 
set "
;" #
}$ %
} 
} ë
S/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/DossierDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 

DossierDTO 
: 
BaseModelDTO *
{ 
public		 
Guid		 
Id		 
{		 
get		 
;		 
set		 !
;		! "
}		# $
public

 
string

 
DossierNumber

 #
{

$ %
get

& )
;

) *
set

+ .
;

. /
}

0 1
public 
Guid 
ClientId 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Guid 
? 
FlightId 
{ 
get  #
;# $
set% (
;( )
}* +
public 
Guid 
? 
BookingRoomId "
{# $
get% (
;( )
set* -
;- .
}/ 0
public 
virtual 
ICollection "
<" #
DossierFlight# 0
>0 1
dossierFlights2 @
{A B
getC F
;F G
setH K
;K L
}M N
public 
virtual 
Client 
Client $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
virtual 
Flight 
Flight $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public 
virtual 
BookingRoom "
BookingRoom# .
{/ 0
get1 4
;4 5
set6 9
;9 :
}; <
} 
} ±
Y/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/DossierFlightDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
DossierFlightDTO !
{ 
public		 

Guid		 
	DossierId		 
{		 
get		 
;		  
set		! $
;		$ %
}		& '
public

 

Guid

 
FlightId

 
{

 
get

 
;

 
set

  #
;

# $
}

% &
public 


DossierDTO 
Dossier 
{ 
get  #
;# $
set% (
;( )
}* +
public 

	FlightDTO 
Flight 
{ 
get !
;! "
set# &
;& '
}( )
} 
} «

[/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/EmailConfiguration.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
EmailConfiguration #
{ 
public	 
string 
From 
{ 
get !
;! "
set# &
;& '
}( )
=* +
null, 0
!0 1
;1 2
public		 
string		 

SmtpServer		  
{		! "
get		# &
;		& '
set		( +
;		+ ,
}		- .
=		/ 0
null		1 5
!		5 6
;		6 7
public

 
int

 
Port

 
{

 
get

 
;

 
set

 "
;

" #
}

$ %
public 
string 
UserName 
{  
get! $
;$ %
set& )
;) *
}+ ,
=- .
null/ 3
!3 4
;4 5
public 
string 
Password 
{  
get! $
;$ %
set& )
;) *
}+ ,
=- .
null/ 3
!3 4
;4 5
} 
} ı	
Q/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/ExtraDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
ExtraDTO 
: 
BaseModelDTO (
{ 
public		 

Guid		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		  
public

 

string

 

OptionName

 
{

 
get

 "
;

" #
set

$ '
;

' (
}

) *
public 

bool 
IsFree 
{ 
get 
; 
set !
;! "
}# $
public 

decimal 
OptionPrice 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 

bool 
IsActive 
{ 
get 
; 
set  #
;# $
}% &
public 

string 
Icon 
{ 
get 
; 
set !
;! "
}# $
} 
} ù

[/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/FellowTravellerDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
FellowTravellerDTO #
:$ %
BaseModelDTO& 2
{ 
public		 

Guid		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		  
public

 

string

 
Relationship

 
{

  
get

! $
;

$ %
set

& )
;

) *
}

+ ,
public 

string 
PassportNumber  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

int 
Age 
{ 
get 
; 
set 
; 
}  
public 

Guid 
? 
ClientId 
{ 
get 
;  
set! $
;$ %
}& '
public 

	ClientDTO 
Client 
{ 
get !
;! "
set# &
;& '
}( )
} 
} ‹
Z/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/FlightAirportsDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
FlightAirportsDTO "
:# $
BaseModelDTO% 1
{ 
public 

Guid 
FlightId 
{ 
get 
; 
set  #
;# $
}% &
public 

Guid 
	AirportId 
{ 
get 
;  
set! $
;$ %
}& '
public 


AirportDTO 
Airport 
{ 
get  #
;# $
set% (
;( )
}* +
public		 

	FlightDTO		 
Flight		 
{		 
get		 !
;		! "
set		# &
;		& '
}		( )
}

 
} Ø
R/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/FlightDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 
class	 
	FlightDTO 
: 
BaseModelDTO '
{ 
public		 

Guid		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		  
public

 

DateTime

 

FlightDate

 
{

  
get

! $
;

$ %
set

& )
;

) *
}

+ ,
public 

string 
FlightNumber 
{  
get! $
;$ %
set& )
;) *
}+ ,
} 
} ë
Q/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/HotelDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

partial 
class 
HotelDTO !
:" #
BaseModelDTO$ 0
{ 
public		 

Guid		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		  
public

 

string

 
Name

 
{

 
get

 
;

 
set

 !
;

! "
}

# $
public 

Guid 
	AddressId 
{ 
get 
;  
set! $
;$ %
}& '
public 

string 
Ville 
{ 
get 
; 
set "
;" #
}$ %
public 

string 
Website 
{ 
get 
;  
set! $
;$ %
}& '
public 

double 
Rating 
{ 
get 
; 
set  #
;# $
}% &
public 

string 
Image 
{ 
get 
; 
set "
;" #
}$ %
public 

string 
PhoneNumber 
{ 
get  #
;# $
set% (
;( )
}* +
public 

string 
Email 
{ 
get 
; 
set "
;" #
}$ %
public 

int 
NumberOfRooms 
{ 
get "
;" #
set$ '
;' (
}) *
public 


AddressDTO 
Address 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} Ï
P/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/Message.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
Message 
{ 
public	 
List 
< 
MailboxAddress #
># $
To% '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
public		 
string		 
Subject		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
public

 
string

 
Content

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
public 
Message 
( 
IEnumerable "
<" #
string# )
>) *
to+ -
,- .
string/ 5
subject6 =
,= >
string? E
contentF M
)M N
{ 	
To 
= 
new 
List 
< 
MailboxAddress (
>( )
() *
)* +
;+ ,
To 
. 
AddRange 
( 
to 
. 
Select !
(! "
x" #
=>$ &
new' *
MailboxAddress+ 9
(9 :
$str: A
,A B
xB C
)C D
)D E
)E F
;F G
Subject 
= 
subject 
; 
Content 
= 
content 
; 
} 	
} 
} º
P/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/RoomDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
RoomDTO 
: 
BaseModelDTO '
{ 
public		 

Guid		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		  
public

 

string

 
Type

 
{

 
get

 
;

 
set

 !
;

! "
}

# $
public 

double 
Price 
{ 
get 
; 
set "
;" #
}$ %
public 

decimal 
Discount 
{ 
get !
;! "
set# &
;& '
}( )
public 

bool 
IsAvailable 
{ 
get !
;! "
set# &
;& '
}( )
public 

Guid 
HotelId 
{ 
get 
; 
set "
;" #
}$ %
public 

HotelDTO 
Hotel 
{ 
get 
;  
set! $
;$ %
}& '
public 

ICollection 
< 
BookingRoomDTO %
>% &
BookingRooms' 3
{4 5
get6 9
;9 :
set; >
;> ?
}@ A
public 

ICollection 
< 
ExtraDTO 
>  
Extras! '
{( )
get* -
;- .
set/ 2
;2 3
}4 5
} 
} Â	
T/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/TripDossier.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 

class 
TripDossier 
{		 
public

 
Guid

 
	DossierId

 
{

 
get

  #
;

# $
set

% (
;

( )
}

* +
public 
string 
DossierNumber #
{$ %
get& )
;) *
set+ .
;. /
}0 1
public 
string 
LastName 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
Guid 
ClientId 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Guid 
FlightId 
{ 
get "
;" #
set$ '
;' (
}) *
public 
Guid 
BookingRoomId !
{" #
get$ '
;' (
set) ,
;, -
}. /
} 
} π
P/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/DTO/UserDTO.cs
	namespace 	
Trip
 
. 
Services 
. 
DTO 
{ 
public 	
class
 
UserDTO 
: 
BaseModelDTO &
{ 
public		 

Guid		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		  
public

 

string

 
Email

 
{

 
get

 
;

 
set

 "
;

" #
}

$ %
public 

string 
Password 
{ 
get  
;  !
set" %
;% &
}' (
public 

string 
	FirstName 
{ 
get !
;! "
set# &
;& '
}( )
public 

string 
LastName 
{ 
get  
;  !
set" %
;% &
}' (
public 

string 
PhoneNumber 
{ 
get  #
;# $
set% (
;( )
}* +
public 

string 
PassportNumber  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

AddressDTO 
Adresse  
{! "
get# &
;& '
set( +
;+ ,
}- .
} 
} Ï
_/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Interfaces/IAirportService.cs
	namespace		 	
Trip		
 
.		 
Services		 
.		 

Interfaces		 "
{

 
public 

	interface 
IAirportService $
{ 
IEnumerable 
< 

AirportDTO 
> 
GetAllAirports  .
(. /
)/ 0
;0 1
} 
} ‹
c/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Interfaces/IBookingRoomService.cs
	namespace 	
Trip
 
. 
Services 
. 

Interfaces "
{ 
public 

	interface 
IBookingRoomService (
{		 
bool

 
CreateBookingRoom

 
(

 
BookingRoomDTO

 -
bookingRoom

. 9
,

9 :
Guid

; ?
	dossierId

@ I
,

I J
Guid

K O
roomId

P V
)

V W
;

W X
} 
} Ï
^/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Interfaces/IClientService.cs
	namespace		 	
Trip		
 
.		 
Services		 
.		 

Interfaces		 "
{

 
public 

	interface 
IClientService #
{ 
Task 
FindByEmailAsync 
( 
string $
email% *
)* +
;+ ,
IEnumerable 
< 
	ClientDTO 
> 
GetAllClients ,
(, -
)- .
;. /
} 
} ‰	
_/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Interfaces/IDossierService.cs
	namespace 	
Trip
 
. 
Services 
. 

Interfaces "
{ 
public		 

	interface		 
IDossierService		 $
{

 

DossierDTO 

AddDossier 
( 

DossierDTO (
tripDossier) 4
)4 5
;5 6
IEnumerable 
< 

DossierDTO 
> 
GetAll  &
(& '
)' (
;( )
IEnumerable 
< 

DossierDTO 
> #
GetDossiersByClientName  7
(7 8
string8 >
	firstName? H
,H I
stringJ P
lastNameQ Y
)Y Z
;Z [
BookedRoomInfoDTO 
BookRoom "
(" #
DateTime# +
	dateDebut, 5
,5 6
DateTime7 ?
dateFin@ G
,G H
GuidI M
UserIDN T
,T U
ListV Z
<Z [
RoomDTO[ b
>b c
myBookedRoomsd q
)q r
;r s
} 
} –
]/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Interfaces/IEmailService.cs
	namespace 	
Trip
 
. 
Services 
. 

Interfaces "
{ 
public 

	interface 
IEmailService "
{ 
void 
	SendEmail 
( 
Message !
message" )
)) *
;* +
} 
}		 È
_/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Interfaces/IFlightsService.cs
	namespace		 	
Trip		
 
.		 
Services		 
.		 

Interfaces		 "
{

 
public 

	interface 
IFlightService #
{ 
IEnumerable 
< 
	FlightDTO 
> 
GetAllFlights ,
(, -
)- .
;. /
} 
} ‰
]/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Interfaces/IHotelService.cs
	namespace		 	
Trip		
 
.		 
Services		 
.		 

Interfaces		 "
{

 
public 

	interface 
IHotelService "
{ 
IEnumerable 
< 
HotelDTO 
> 
GetAllHotels *
(* +
)+ ,
;, -
} 
} ¨
\/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Interfaces/IUserService.cs
	namespace		 	
Trip		
 
.		 
Services		 
.		 

Interfaces		 "
{

 
public 

	interface 
IUserService !
{ 
IEnumerable 
< 
UserDTO 
> 
GetAllUsers (
(( )
)) *
;* +
UserDTO 
GetUserByEmail 
( 
string %
email& +
)+ ,
;, -
bool 
Register 
( 
UserDTO 
user "
)" #
;# $
	ClientDTO %
GetUserByEmailAndPassword +
(+ ,
string, 2
email3 8
,8 9
string: @
passwordA I
)I J
;J K
} 
} °
b/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/AdressProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public 

class 
AdressProfile 
:  
Profile! (
{		 
public

 
AdressProfile

 
(

 
)

 
{ 	
	CreateMap 
< 
Address 
, 

AddressDTO )
>) *
(* +
)+ ,
;, -
	CreateMap 
< 

AddressDTO  
,  !
Address" )
>) *
(* +
)+ ,
;, -
} 	
} 
} ®
c/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/AirlineProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public		 

class		 
AirlineProfile		 
:		  !
Profile		" )
{

 
public 
AirlineProfile 
( 
) 
{ 	
	CreateMap 
< 
Airplane 
, 
AirplaneDTO  +
>+ ,
(, -
)- .
;. /
	CreateMap 
< 
AirplaneDTO !
,! "
Airplane# +
>+ ,
(, -
)- .
;. /
} 	
} 
} §
c/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/AirportProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public		 

class		 
AirportProfile		 
:		  !
Profile		" )
{

 
public 
AirportProfile 
( 
) 
{ 	
	CreateMap 
< 
Airport 
, 

AirportDTO )
>) *
(* +
)+ ,
;, -
	CreateMap 
< 

AirportDTO  
,  !
Airport" )
>) *
(* +
)+ ,
;, -
} 	
} 
} ¿
g/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/BookingRoomProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public		 

class		 
BookingRoomProfile		 #
:		$ %
Profile		& -
{

 
public 
BookingRoomProfile !
(! "
)" #
{ 	
	CreateMap 
< 
BookingRoom !
,! "
BookingRoomDTO# 1
>1 2
(2 3
)3 4
;4 5
	CreateMap 
< 
BookingRoomDTO $
,$ %
BookingRoom& 1
>1 2
(2 3
)3 4
;4 5
} 	
} 
} ù
b/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/ClientProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public 

class 
ClientProfile 
:  
Profile! (
{		 
public

 
ClientProfile

 
(

 
)

 
{ 	
	CreateMap 
< 
Client 
, 
	ClientDTO '
>' (
(( )
)) *
;* +
	CreateMap 
< 
	ClientDTO 
,  
Client! '
>' (
(( )
)) *
;* +
} 	
} 
} ù
b/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/FlightProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public		 

class		 
FlightProfile		 
:		  
Profile		! (
{

 
public 
FlightProfile 
( 
) 
{ 	
	CreateMap 
< 
Flight 
, 
	FlightDTO '
>' (
(( )
)) *
;* +
	CreateMap 
< 
	FlightDTO 
,  
Flight! '
>' (
(( )
)) *
;* +
} 	
} 
} ñ
a/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/HotelProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public		 

class		 
HotelProfile		 
:		 
Profile		  '
{

 
public 
HotelProfile 
( 
) 
{ 	
	CreateMap 
< 
Hotel 
, 
HotelDTO %
>% &
(& '
)' (
;( )
	CreateMap 
< 
HotelDTO 
, 
Hotel  %
>% &
(& '
)' (
;( )
} 	
} 
} è
`/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/RoomProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public		 

class		 
RoomProfile		 
:		 
Profile		 &
{

 
public 
RoomProfile 
( 
) 
{ 	
	CreateMap 
< 
Room 
, 
RoomDTO #
># $
($ %
)% &
;& '
	CreateMap 
< 
RoomDTO 
, 
Room #
># $
($ %
)% &
;& '
} 	
} 
} ∞
g/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/TripDossierProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public		 

class		 
TripDossierProfile		 #
:		$ %
Profile		& -
{

 
public 
TripDossierProfile !
(! "
)" #
{ 	
	CreateMap 
< 
Dossier 
, 

DossierDTO )
>) *
(* +
)+ ,
;, -
	CreateMap 
< 

DossierDTO  
,  !
Dossier" )
>) *
(* +
)+ ,
;, -
} 	
} 
} è
`/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/MappingProfiles/UserProfile.cs
	namespace 	
Trip
 
. 
Services 
. 
MappingProfiles '
{ 
public		 

class		 
UserProfile		 
:		 
Profile		 &
{

 
public 
UserProfile 
( 
) 
{ 	
	CreateMap 
< 
User 
, 
UserDTO #
># $
($ %
)% &
;& '
	CreateMap 
< 
UserDTO 
, 
User #
># $
($ %
)% &
;& '
} 	
} 
} ˛
\/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Services/AirportService.cs
	namespace 	
Trip
 
. 
Services 
. 
Services  
{ 
public 

class 
AirportService 
:  !
IAirportService" 1
{ 
public 
IUnitOfWork 
_unitOfWork &
;& '
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
IAirportRepository +
_airportRepository, >
;> ?
public 
AirportService 
( 
IUnitOfWork )

unitOfWork* 4
,4 5
IMapper6 =
mapper> D
,D E
IAirportRepository 
airportRepository 0
)0 1
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_airportRepository 
=  
airportRepository! 2
;2 3
_mapper 
= 
mapper 
; 
} 	
public 
IEnumerable 
< 

AirportDTO )
>) *
GetAllAirports+ 9
(9 :
): ;
{ 	
var 
airportsList 
= 
this  $
.$ %
_unitOfWork% 0
.0 1
Airports1 9
.9 :
GetAll: @
(@ A
)A B
;B C
return   
(   
_mapper   
.   
Map    
<    !
IEnumerable  ! ,
<  , -

AirportDTO  - 7
>  7 8
>  8 9
(  9 :
airportsList  : F
)  F G
)  G H
;  H I
}!! 	
}## 
}$$ ë
`/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Services/BookingRoomService.cs
	namespace 	
Trip
 
. 
Services 
. 
Services  
{ 
public 

class 
BookingRoomService #
:$ %
IBookingRoomService& 9
{ 
private 
readonly 
IUnitOfWork $
_unitOfWork% 0
;0 1
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly "
IBookingRoomRepository /"
_bookingRoomRepository0 F
;F G
public 
BookingRoomService !
(! "
IUnitOfWork" -

unitOfWork. 8
,8 9
IMapper: A
mapperB H
,H I"
IBookingRoomRepository "!
bookingRoomRepository# 8
)8 9
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %"
_bookingRoomRepository "
=# $!
bookingRoomRepository% :
;: ;
_mapper 
= 
mapper 
; 
} 	
public 
bool 
CreateBookingRoom %
(% &
BookingRoomDTO& 4
bookingRoom5 @
,@ A
GuidB F
	dossierIdG P
,P Q
GuidR V
roomIdW ]
)] ^
{ 	
_unitOfWork 
. 
BookingRooms (
.( )
Add) ,
(, -
_mapper- 4
.4 5
Map5 8
<8 9
BookingRoom9 D
>D E
(E F
bookingRoomF Q
)Q R
)R S
;S T
_unitOfWork 
. 
Save !
(! "
)" #
;# $
var"" 
dossier"" 
="" 
_mapper"" %
.""% &
Map""& )
<"") *

DossierDTO""* 4
>""4 5
(""5 6
_unitOfWork""6 A
.""A B
Dossiers""B J
.""J K
GetById""K R
(""R S
	dossierId""S \
)""\ ]
)""] ^
;""^ _
dossier## 
.## 
BookingRoomId## %
=##& '
bookingRoom##( 3
.##3 4
Id##4 6
;##6 7
_unitOfWork$$ 
.$$ 
Dossiers$$ $
.$$$ %
Update$$% +
($$+ ,
_mapper$$, 3
.$$3 4
Map$$4 7
<$$7 8
Dossier$$8 ?
>$$? @
($$@ A
dossier$$A H
)$$H I
)$$I J
;$$J K
var'' 
room'' 
='' 
_mapper'' "
.''" #
Map''# &
<''& '
RoomDTO''' .
>''. /
(''/ 0
_unitOfWork''0 ;
.''; <
Rooms''< A
.''A B
GetById''B I
(''I J
roomId''J P
)''P Q
)''Q R
;''R S
room(( 
.(( 
BookingRooms(( !
.((! "
Add((" %
(((% &
bookingRoom((& 1
)((1 2
;((2 3
_unitOfWork)) 
.)) 
Rooms)) !
.))! "
Update))" (
())( )
_mapper))) 0
.))0 1
Map))1 4
<))4 5
Room))5 9
>))9 :
()): ;
room)); ?
)))? @
)))@ A
;))A B
_unitOfWork,, 
.,, 
Save,, !
(,,! "
),," #
;,,# $
return.. 
true.. 
;.. 
}// 	
}00 
}11 Æ
[/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Services/ClientService.cs
	namespace 	
Trip
 
. 
Services 
. 
Services  
{ 
public 

class 
ClientService 
:  
IClientService! /
{ 
public 
IUnitOfWork 
_unitOfWork &
;& '
public 
IClientRepository  
_clientRepository! 2
;2 3
public 
IMapper 
_mapper 
; 
public 
ClientService 
( 
IUnitOfWork (

unitOfWork) 3
,3 4
IMapper5 <
mapper= C
,C D
IClientRepositoryE V
clientRepositoryW g
)g h
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
_clientRepository 
= 
clientRepository  0
;0 1
} 	
public 
Task 
FindByEmailAsync $
($ %
string% +
email, 1
)1 2
=>3 5
throw6 ;
new< ?#
NotImplementedException@ W
(W X
)X Y
;Y Z
public 
IEnumerable 
< 
	ClientDTO %
>% &
GetAllClients' 4
(4 5
)5 6
{ 	
var   
clientsList   
=   
_unitOfWork   *
.  * +
Clients  + 2
.  2 3
GetAll  3 9
(  9 :
)  : ;
;  ; <
return!! 
(!! 
_mapper!! 
.!! 
Map!! 
<!!  
IEnumerable!!  +
<!!+ ,
	ClientDTO!!, 5
>!!5 6
>!!6 7
(!!7 8
clientsList!!8 C
)!!C D
)!!D E
;!!E F
}"" 	
}## 
}$$ ù+
\/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Services/DossierService.cs
	namespace 	
Trip
 
. 
Services 
. 
Services  
{ 
public 

class 
DossierService 
:  !
IDossierService" 1
{ 
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
IDossierRepository +
_dossierRepository, >
;> ?
private 
readonly 
IConfiguration '
_config( /
;/ 0
public	 
IUnitOfWork 
_unitOfWork '
;' (
public 
DossierService 
( 
IMapper %
mapper& ,
,, -
IDossierRepository 
dossierRepository 0
,0 1
IConfiguration 
config !
,! "
IUnitOfWork 

unitOfWork "
)" #
{ 	
_mapper 
= 
mapper 
; 
_dossierRepository 
=  
dossierRepository! 2
;2 3
_config 
= 
config 
; 
_unitOfWork 
= 

unitOfWork $
;$ %
} 	
public!! 
BookedRoomInfoDTO!! !
BookRoom!!" *
(!!* +
DateTime!!+ 3
	dateDebut!!4 =
,!!= >
DateTime!!? G
dateFin!!H O
,!!O P
Guid!!Q U
UserID!!V \
,!!\ ]
List!!^ b
<!!b c
RoomDTO!!c j
>!!j k
myBookedRooms!!l y
)!!y z
{!!{ |
var"" 
rooms"" 	
=""
 
myBookedRooms"" 
."" 
Select""  
(""  !
roomDto""! (
=>"") +
_mapper"", 3
.""3 4
Map""4 7
<""7 8
Trip""8 <
.""< =
Data""= A
.""A B
Models""B H
.""H I
Room""I M
>""M N
(""N O
roomDto""O V
)""V W
)""W X
.""X Y
ToList""Y _
(""_ `
)""` a
;""a b
var$$ 
BookedRoomInfo$$ 
=$$  
_mapper$$! (
.$$( )
Map$$) ,
<$$, -
BookedRoomInfoDTO$$- >
>$$> ?
($$? @
_dossierRepository$$@ R
.$$R S
CreateDossier$$S `
($$` a
	dateDebut$$b k
,$$k l
dateFin$$n u
,$$u v
UserID$$w }
,$$} ~
rooms	$$ Ñ
)
$$Ñ Ö
)
$$Ö Ü
;
$$Ü á
return%% 
BookedRoomInfo%% !
;%%! "
}'' 	
public)) 

DossierDTO)) 

AddDossier)) $
())$ %

DossierDTO))% /
tripDossier))0 ;
))); <
{** 	
var++ 
dossier++ 
=++ 
new++ 

DossierDTO++ (
{++( )
Id,, 
=,, 
Guid,, 
.,, 
NewGuid,, !
(,,! "
),," #
,,,# $
DossierNumber-- 
=-- 
tripDossier--  +
.--+ ,
DossierNumber--, 9
,--9 :
BookingRoomId.. 
=.. 
tripDossier..  +
...+ ,
BookingRoomId.., 9
,..9 :
ClientId// 
=// 
tripDossier// &
.//& '
ClientId//' /
,/// 0
FlightId00 
=00 
tripDossier00 &
.00& '
FlightId00' /
}11 
;11 
_dossierRepository22  
.22  !
CreateDossier22! .
(22. /
_mapper22/ 6
.226 7
Map227 :
<22: ;
Dossier22; B
>22B C
(22C D
dossier22D K
)22K L
)22L M
;22M N
return44 
dossier44 
;44 
}55 	
public77 
IEnumerable77 
<77 

DossierDTO77 %
>77% &
GetAll77' -
(77- .
)77. /
{88 	
var99 
dossiersList99 
=99 
_dossierRepository99" 4
.994 5
GetAllReservations995 G
(99G H
)99H I
;99I J
return:: 
_mapper:: 
.:: 
Map:: 
<:: 
IEnumerable:: )
<::) *

DossierDTO::* 4
>::4 5
>::5 6
(::6 7
dossiersList::7 C
)::C D
;::D E
};; 	
public<< 
IEnumerable<< 
<<< 

DossierDTO<< &
><<& '#
GetDossiersByClientName<<( ?
(<<? @
string<<@ F
	firstName<<G P
,<<P Q
string<<R X
lastName<<Y a
)<<a b
{== 	
var>> 
dossierList>> 
=>> 
_dossierRepository>> 1
.>>1 2#
GetDossiersByClientName>>2 I
(>>I J
	firstName>>J S
,>>S T
lastName>>U ]
)>>] ^
;>>^ _
return?? 
_mapper?? 
.?? 
Map?? 
<?? 
IEnumerable?? *
<??* +

DossierDTO??+ 5
>??5 6
>??6 7
(??7 8
dossierList??8 C
)??C D
;??D E
}@@ 	
}BB 
}CC Å 
Z/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Services/EmailService.cs
	namespace 	
Trip
 
. 
Services 
. 
Services  
{ 
public 
class 
EmailService 
:  
IEmailService! .
{ 
private		 
readonly		 
EmailConfiguration		 +
_emailConfig		, 8
;		8 9
public

 
EmailService

 
(

 
EmailConfiguration

 .
emailConfig

/ :
)

: ;
=>

< >
_emailConfig

? K
=

L M
emailConfig

N Y
;

Y Z
public 
void 
	SendEmail 
( 
Message %
message& -
)- .
{ 	
var 
emailMessage 
= 
CreateEmailMessage 1
(1 2
message2 9
)9 :
;: ;
Send 
( 
emailMessage 
) 
; 
} 	
private 
MimeMessage 
CreateEmailMessage .
(. /
Message/ 6
message7 >
)> ?
{ 	
var 
emailMessage 
= 
new "
MimeMessage# .
(. /
)/ 0
;0 1
emailMessage 
. 
From 
. 
Add !
(! "
new" %
MailboxAddress& 4
(4 5
$str5 <
,< =
_emailConfig= I
.I J
FromJ N
)N O
)O P
;P Q
emailMessage 
. 
To 
. 
AddRange $
($ %
message% ,
., -
To- /
)/ 0
;0 1
emailMessage 
. 
Subject  
=! "
message# *
.* +
Subject+ 2
;2 3
emailMessage 
. 
Body 
= 
new  #
TextPart$ ,
(, -
MimeKit- 4
.4 5
Text5 9
.9 :

TextFormat: D
.D E
TextE I
)I J
{K L
TextM Q
=R S
messageT [
.[ \
Content\ c
}d e
;e f
return 
emailMessage 
;  
} 	
private 
void 
Send 
( 
MimeMessage %
mailMessage& 1
)1 2
{ 	
using 
var 
client 
= 
new "

SmtpClient# -
(- .
). /
;/ 0
try 
{   
client!! 
.!! 
Connect!! 
(!! 
_emailConfig!! +
.!!+ ,

SmtpServer!!, 6
,!!6 7
_emailConfig!!8 D
.!!D E
Port!!E I
,!!I J
true!!K O
)!!O P
;!!P Q
client"" 
."" $
AuthenticationMechanisms"" /
.""/ 0
Remove""0 6
(""6 7
$str""7 @
)""@ A
;""A B
client## 
.## 
Authenticate## #
(### $
_emailConfig##$ 0
.##0 1
UserName##1 9
,##9 :
_emailConfig##; G
.##G H
Password##H P
)##P Q
;##Q R
client%% 
.%% 
Send%% 
(%% 
mailMessage%% '
)%%' (
;%%( )
}&& 
catch'' 
{(( 
throw** 
;** 
}++ 
finally,, 
{-- 
client.. 
... 

Disconnect.. !
(..! "
true.." &
)..& '
;..' (
client// 
.// 
Dispose// 
(// 
)//  
;//  !
}00 
}11 	
}22 
}33 ´
[/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Services/FlightService.cs
	namespace 	
Trip
 
. 
Services 
. 
Services  
{ 
public 

class 
FlightService 
:  
IFlightService! /
{ 
public 
IUnitOfWork 
_unitOfWork &
;& '
public 
IFlightRepository  
_flightRepository! 2
;2 3
public 
IMapper 
_mapper 
; 
public 
FlightService 
( 
IUnitOfWork (

unitOfWork) 3
,3 4
IMapper5 <
mapper= C
,C D
IFlightRepository 
flightRepository .
). /
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_flightRepository 
= 
flightRepository  0
;0 1
_mapper 
= 
mapper 
; 
} 	
public 
IEnumerable 
< 
	FlightDTO %
>% &
GetAllFlights' 4
(4 5
)5 6
{ 	
var   
FlightsList   
=   
_unitOfWork   *
.  * +
Flights  + 2
.  2 3 
GetAllFlightsDetails  3 G
(  G H
)  H I
;!! 
return"" 
("" 
_mapper"" 
."" 
Map"" 
<""  
IEnumerable""  +
<""+ ,
	FlightDTO"", 5
>""5 6
>""6 7
(""7 8
FlightsList""8 C
)""C D
)""D E
;""E F
}## 	
}(( 
}))  
Z/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Services/HotelService.cs
	namespace 	
Trip
 
. 
Services 
. 
Services  
{ 
public 

class 
HotelService 
: 
IHotelService  -
{ 
public 
IUnitOfWork 
_unitOfWork &
;& '
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
IHotelRepository )
_hotelRepository* :
;: ;
public 
HotelService 
( 
IUnitOfWork '

unitOfWork( 2
,2 3
IMapper4 ;
mapper< B
,B C
IHotelRepository 
hotelRepository ,
), -
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_hotelRepository 
= 
hotelRepository .
;. /
_mapper 
= 
mapper 
; 
} 	
public!! 
IEnumerable!! 
<!! 
HotelDTO!! $
>!!$ %
GetAllHotels!!& 2
(!!2 3
)!!3 4
{"" 	
var## 

hotelsList## 
=## 
_unitOfWork## )
.##) *
Hotels##* 0
.##0 1
GetAllHotelsDetails##1 D
(##D E
)##E F
;##F G
return$$ 
($$ 
_mapper$$ 
.$$ 
Map$$ 
<$$  
IEnumerable$$  +
<$$+ ,
HotelDTO$$, 4
>$$4 5
>$$5 6
($$6 7

hotelsList$$7 A
)$$A B
)$$B C
;$$C D
}%% 	
}(( 
}(( ¥<
Y/home/firas/Musique/05_04_2024 backend/Trip_Backend/Trip.Services/Services/UserService.cs
	namespace 	
Trip
 
. 
Services 
. 
Services  
{ 
public 

class 
UserService 
: 
IUserService +
{ 
public 
IUnitOfWork 
_unitOfWork &
;& '
private 
readonly 
IMapper  
_mapper! (
;( )
private 
readonly 
IUserRepository (
_userRepository) 8
;8 9
public 
UserService 
( 
IUnitOfWork &

unitOfWork' 1
,1 2
IMapper3 :
mapper; A
,A B
IUserRepositoryC R
userRepositoryS a
)a b
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_userRepository 
= 
userRepository ,
;, -
_mapper 
= 
mapper 
; 
} 	
public!! 
IEnumerable!! 
<!! 
UserDTO!! "
>!!" #
GetAllUsers!!$ /
(!!/ 0
)!!0 1
{"" 	
var## 
	usersList## 
=## 
_unitOfWork## (
.##( )
Users##) .
.##. /
GetAll##/ 5
(##5 6
)##6 7
;##7 8
return$$ 
($$ 
_mapper$$ 
.$$ 
Map$$ 
<$$  
IEnumerable$$  +
<$$+ ,
UserDTO$$, 3
>$$3 4
>$$4 5
($$5 6
	usersList$$6 ?
)$$? @
)$$@ A
;$$A B
}%% 	
public'' 
UserDTO'' 
GetUserByEmail'' %
(''% &
string''& ,
email''- 2
)''2 3
{(( 	
var** 
user** 
=** 
_unitOfWork** #
.**# $
Users**$ )
.**) *

GetByEmail*** 4
(**4 5
email**5 :
)**: ;
;**; <
if++ 
(++ 
user++ 
!=++ 
null++ 
)++ 
{,, 
return-- 
(-- 
_mapper-- 
.--  
Map--  #
<--# $
UserDTO--$ +
>--+ ,
(--, -
user--- 1
)--1 2
)--2 3
;--3 4
}.. 
return00 
null00 
;00 
}11 	
public33 
bool33 
Register33 
(33 
UserDTO33 $
user33% )
)33) *
{44 	
if55 
(55 
user55 
!=55 
null55 
)55 
{66 

AddressDTO77 
adr77 
=77  
new77! $

AddressDTO77% /
(77/ 0
)770 1
;771 2
adr88 
.88 

PostalCode88 
=88  
user88! %
.88% &
Adresse88& -
.88- .

PostalCode88. 8
;888 9
adr99 
.99 
Country99 
=99 
user99 "
.99" #
Adresse99# *
.99* +
Country99+ 2
;992 3
adr:: 
.:: 
City:: 
=:: 
user:: 
.::  
Adresse::  '
.::' (
City::( ,
;::, -
adr;; 
.;; 
Region;; 
=;; 
user;; !
.;;! "
Adresse;;" )
.;;) *
Region;;* 0
;;;0 1
_unitOfWork<< 
.<< 
Adresses<< $
.<<$ %
CreateAdress<<% 1
(<<1 2
_mapper<<2 9
.<<9 :
Map<<: =
<<<= >
Address<<> E
><<E F
(<<F G
adr<<G J
)<<J K
)<<K L
;<<L M
var== 
savedAdressId== !
===" #
_unitOfWork==$ /
.==/ 0
SaveReturnGuid==0 >
<==> ?
Address==? F
>==F G
(==G H
)==H I
;==I J
UserDTO?? 
registredUser?? %
=??& '
new??( +
UserDTO??, 3
(??3 4
)??4 5
;??5 6
registredUser@@ 
.@@ 
Email@@ #
=@@$ %
user@@& *
.@@* +
Email@@+ 0
;@@0 1
registredUserAA 
.AA 
PasswordAA &
=AA' (
userAA) -
.AA- .
PasswordAA. 6
;AA6 7
registredUserBB 
.BB 
	FirstNameBB '
=BB( )
userBB* .
.BB. /
	FirstNameBB/ 8
;BB8 9
registredUserCC 
.CC 
LastNameCC &
=CC' (
userCC) -
.CC- .
LastNameCC. 6
;CC6 7
registredUserDD 
.DD 
PhoneNumberDD )
=DD* +
userDD, 0
.DD0 1
PhoneNumberDD1 <
;DD< =
_unitOfWorkEE 
.EE 
UsersEE !
.EE! "

CreateUserEE" ,
(EE, -
_mapperEE- 4
.EE4 5
MapEE5 8
<EE8 9
UserEE9 =
>EE= >
(EE> ?
registredUserEE? L
)EEL M
)EEM N
;EEN O
varFF 
savedUserIdFF 
=FF  !
_unitOfWorkFF" -
.FF- .
SaveReturnGuidFF. <
<FF< =
UserFF= A
>FFA B
(FFB C
)FFC D
;FFD E
	ClientDTOII 
clientII  
=II! "
newII# &
	ClientDTOII' 0
{JJ 
ClientIdKK 
=KK 
GuidKK #
.KK# $
NewGuidKK$ +
(KK+ ,
)KK, -
,KK- .
PassportNumberLL "
=LL# $
userLL% )
.LL) *
PassportNumberLL* 8
,LL8 9
IsActiveMM 
=MM 
trueMM #
,MM# $
	AdresseIdNN 
=NN 
savedAdressIdNN  -
,NN- .
UserIdOO 
=OO 
savedUserIdOO (
}QQ 
;QQ 
_unitOfWorkRR 
.RR  
ClientsRR  '
.RR' (
AddRR( +
(RR+ ,
_mapperRR, 3
.RR3 4
MapRR4 7
<RR7 8
ClientRR8 >
>RR> ?
(RR? @
clientRR@ F
)RRF G
)RRG H
;RRH I
varSS 
resultSS 
=SS  
_unitOfWorkSS! ,
.SS, -
SaveSS- 1
(SS1 2
)SS2 3
;SS3 4
returnUU 
resultUU 
>UU 
$numUU  !
;UU! "
}VV 
returnWW 
falseWW 
;WW 
}XX 	
publicYY 
	ClientDTOYY %
GetUserByEmailAndPasswordYY 2
(YY2 3
stringYY3 9
emailYY: ?
,YY? @
stringYYA G
passwordYYH P
)YYP Q
{ZZ 	
var\\ 
user\\ 
=\\ 
_unitOfWork\\ #
.\\# $
Users\\$ )
.\\) *!
GetByEmailAndPassword\\* ?
(\\? @
email\\@ E
,\\E F
password\\G O
)\\O P
;\\P Q
if__ 
(__ 
user__ 
!=__ 
null__ 
)__ 
{`` 
returnaa 
_mapperaa 
.aa 
Mapaa "
<aa" #
	ClientDTOaa# ,
>aa, -
(aa- .
useraa. 2
)aa2 3
;aa3 4
}bb 
returndd 
nulldd 
;dd 
}ee 	
}gg 
}hh 