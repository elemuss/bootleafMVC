BootLeafMVC
========

This is an extension of BootLeaf (https://github.com/bmcbride/bootleaf) by Bryan McBride - a simple template for building web mapping applications with Bootstrap 3 and Leaflet. The app has been refactored as a .net MVC 4 app, and has the following new features.
* Spatial data stored in SQL server
* MVC data access layer
 
To use
* Back up the 'bootleaf' file in the bootleaf\database folder to your SQL Server
* Point your connection string in your web.config file to that DB and you should be good to go!!


Demo coming soon!!

###Original Release Notes 
* Simple Demo: http://bmcbride.github.io/bootleaf/
* Sidebar Demo: http://bmcbride.github.io/bootleaf/sidebar.html

### Features:
* Fullscreen mobile-friendly map template with responsive Navbar and modal placeholders
* jQuery loading of external GeoJSON files
* Elegant client-side multi-layer feature search with autocomplete using Twitter's typeahead.js
* Integration of Bootstrap tables into Leaflet popups
* Logic for minimizing Layer Control and removing Scale Control on small screens
* Marker icons included in Layer Control

![screenshot](http://bmcbride.github.io/bootleaf/screenshot.jpg)
