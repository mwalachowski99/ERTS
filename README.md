# E-SPORT RESULTS TRACKING SYSTEM (ERTS)

ERTS (E-Sport Results Tracking System) is a web application project designed to visualize statistics and results from e-sports competitions. The goal of the application is to provide a clear interface for users who want to track statistics from e-sports games, such as League of Legends, Counter-Strike: Global Offensive, Dota 2, Overwatch, and Valorant. The project also includes a module for automatically fetching and updating data.

---

## Key Features

1. **Match Results Viewing:**
   - Results of matches for selected games.
   - Statistics for e-sports tournaments.

2. **Detailed Statistics:**
   - Player and team statistics in tournaments.
   - Detailed data for League of Legends games, such as the number of kills, assists, destroyed objects, or earned gold.

3. **E-sports Structure Overview:**
   - Information about leagues, series, tournaments, and teams.

4. **Search and Filtering:**
   - Searching leagues and teams by name.

5. **Multilingual Interface:**
   - Support for Polish, English, Italian, and Chinese languages.

6. **Automatic Updates:**
   - The `ErtsApiFetcher` module automatically fetches e-sports data from the PandaScore API and updates the database.

---

## Technologies Used in the Project

- **Backend:** C#, .NET Core
- **Frontend:** React, TypeScript, Bootstrap
- **Database:** PostgreSQL
- **API:** PandaScore
- **Task Management:** Hangfire
- **Version Control:** Git

---

## System Architecture

The system consists of four main modules:
1. **ErtsModel:** Manages the data structure.
2. **ErtsApplication:** Implements the business logic of the application.
3. **ErtsWebApp:** Frontend of the web application.
4. **ErtsApiFetcher:** A module responsible for fetching and updating data from external APIs.

---

## Development and Future Plans

The current version focuses on League of Legends statistics, but there are plans to expand support for detailed data for other games. The system will be developed with new data types and views.

---

## Limitations

- The free version of the PandaScore API limits the number of hourly requests and the availability of detailed statistics.
- For demonstration purposes, sample statistics were used to showcase the application's capabilities.

---

📄 [Read more](PracaInz_Wałachowski_S19541.pdf)

## Screenshots
### League list
![image](https://github.com/user-attachments/assets/16b27f0b-163f-4942-8c16-fb659c3fc6cd)
### Tournament list
![image](https://github.com/user-attachments/assets/db5ed6d1-746c-4431-a77b-6541f9837151)
### Players stats
![image](https://github.com/user-attachments/assets/84a23485-93fb-4085-ae01-6f10a8bdc5cb)
### Game info
![image](https://github.com/user-attachments/assets/458b655c-aab1-45d8-a3ce-07147f402a47)



