       body {
            background-image: url('images/itemployees.jpg');
            background-size: cover;
            background-position: top center;
            background-repeat: no-repeat;
            font-family: Arial, sans-serif;
            color: #ffffff;
            margin: 0;
            padding: 0;
        }

        /* Header styles */
        h1 {
            font-family: 'Verdana', sans-serif; 
            color: #ffffff; 
            text-align: center; 
            margin-top: 50px;
        }

        h2 {
            font-family: 'Arial', sans-serif; 
            color: #ffffff;
            margin-top: 20px;
        }

        /* Link styles */
        a:link,
        a:visited {
            color: #ffffff; 
            text-decoration: none;
        }

        a:hover,
        a:active {
            color: #003366;
        }

        /* Navbar styles */
        nav {
            background-color: rgba(0, 0, 0, 0.8);
            padding: 15px 0;
            text-align: right;
            padding-right: 1000px;
        }

        /* Navbar link styles */
        nav a:link,
        nav a:visited {
            color: #ffffff;
            text-decoration: none;
            padding: 8px 15px;
            display: inline-block;
            text-align: left;
            z-index: 10;
            position: relative;
        }

        nav a:hover,
        nav a:active {
            color: #a92d56;
            transform: scale(1.2);
        }

        /* Navbar list styles */
        nav ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
        }

        nav ul li {
            display: inline;
        }

        /* Content styles */
        .content {
            text-align: center;
            padding: 50px 20px;
        }

        .celtec {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        z-index: 10;
        }

        .celtec img {
        pointer-events: none;
        }