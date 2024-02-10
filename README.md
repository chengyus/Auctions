# FreeCodeCamp Follow-along Public Repo for the Video URL of 

https://www.youtube.com/watch?v=nKovSmd5DWY

which is the 2024 ASP.NET Core tutorial video in the FreeCodeCamp Youtube channel.

## My Setup

Because I might use vim to edit or copy lines in the project, I actually had to customize the .gitignore that I understood:
which for now basically .gitignore the compiled output.  The wwwroot for now I basically version-controll it. But I suspect in the future that probably can be .gitignored too becasued I simply want to track the ASP.NET part.

Oh, and for good measure, I followed the SO answer on forcing LF linebreaks:
https://stackoverflow.com/questions/9976986/force-lf-eol-in-git-repo-and-working-copy

## Database Setup

Oh, ya, the FCC YT video didn't say this, but once I got to the database part (or for good measure and smooth sailing), I had to download Microsoft SQL Server 2022 Developer version. (The Express version didn't work; I got naive thinking the PostgreSQL or Npgsql could work. Nope, there are specific field datatype that the default ASP.NET template used that will cause the default generate migration to fail.  But I saw think very good examples on Npgsql website; so perhaps later on a different project or when I find more community pages / guides, Npgsql could totally work; I think some point along the last Adv C# video Npgsql was used with EF Core or something that worked with SQLite... that was smooth sailing).
