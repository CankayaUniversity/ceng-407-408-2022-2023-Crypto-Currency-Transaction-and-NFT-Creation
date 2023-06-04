import { Link } from "react-router-dom";
import styles from "./styles.module.css";
import logo from './images/logo.png'
import inf from './images/inf.png'

const Main = () => {
  const handleLogout = () => {
    localStorage.removeItem("token");
    window.location.reload();
  };

  return (
    <div className={styles.main_container}>
      <nav className={styles.navbar}>
      <img src={logo} alt="Logo" className={styles.logo} />
        <h1>STARRY GOLD BILLFOLD</h1>
          
        <div className={styles.logo_container}>
          <img src={inf} alt="inf" className={styles.logo} />
          <p className={styles.navbar_text}>Infinium Coin</p> {/* Add the text element */}
        </div>
       
        
        <div className={styles.logo_container}></div>
        <div className={styles.button_wrapper}>
          <Link to="http://localhost:5173/" className={styles.button_link}>
            Transaction
          </Link>
        </div>
        <button className={styles.white_btn} onClick={handleLogout}>
          Logout
        </button>
      </nav>
    </div>
  );
};

export default Main;
