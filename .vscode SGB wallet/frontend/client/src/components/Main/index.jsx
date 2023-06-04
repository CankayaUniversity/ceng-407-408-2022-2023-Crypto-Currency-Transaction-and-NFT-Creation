import { Link } from "react-router-dom";
import styles from "./styles.module.css";
import logo from './images/logo.png'
import inff from './images/inff.png'
import logolar from './images/logolar.jpg'


const Main = () => {
  const handleLogout = () => {
    localStorage.removeItem("token");
    window.location.reload();
  };

  return (
    <div className={styles.main_container}>
      <nav className={styles.navbar}>
      <img src={logo} alt="Logo" className={styles.logo} style={{ position: 'absolute', top: '-150px', left: '0', color: 'white', fontWeight: 'bold' }} />
      
      <p className={styles.baslik} style={{ position: 'absolute', bottom: '0',left: '50%', transform: 'translateX(-50%)',top: '0', color: 'white', fontWeight: 'bold' }}> <h1>STARRY GOLD BILLFOLD</h1> </p>
       
        <div className={styles.logo_container}>
          <img src={inff} alt="inff" className={styles.logo}  style={{ position: 'absolute', bottom: '0',left: '50%', transform: 'translateX(-50%)',top: '0', color: 'white', fontWeight: 'bold' }}></img>
          <p className={styles.logo_text}  style={{ position: 'absolute', bottom: '150px',left: '50%', transform: 'translateX(-50%)',top: '-50', color: 'white', fontWeight: 'bold' }}>
          <h3 >Welcome to Starry Gold Billfold, your newest and most secure crypto wallet!</h3>

          A innovative wallet software called Starry Gold Billfold enables customers to safely handle their digital valuables.
          This platform's user-friendly layout is ideal for both beginners and expert users, making it possible for anyone to easily manage and trade crypto assets.
          Become a member of Starry Gold Billfold right away to begin managing your digital possessions safely.
          Choose us for a convenient wallet experience powered by ultra-modern technology.
        </p>

        </div>
       
        
        <div className={styles.logo_container}></div>
        <div className={styles.button_wrapper}>
          <Link to="http://localhost:5173/" className={styles.button_link}>
            Transaction
          </Link>

        </div>
        <div className={styles.logo_container}></div>
        <div className={styles.button_wrapper}>
          <Link to="https://sepolia.etherscan.io/nft/0xe163e31e95f9aa692a66e0e254c4e2064ff731ad/0" className={styles.button_link}>
            Infinium NFT 
          </Link>

        </div>
        <button className={styles.white_btn} onClick={handleLogout}>
          Logout
        </button>
      </nav>

      <footer className={styles.footer}>
      <img src={logolar} alt="Logo" className={styles.footer_image} style={{ position: 'absolute', bottom: '0' ,left: '50%', transform: 'translateX(-50%)'}} />
      <p className={styles.footer_text} style={{ position: 'absolute', bottom: '0',left: '50%', transform: 'translateX(-50%)',top: '17cm', color: 'white', fontWeight: 'bold' }}>Contact Us </p>
       
    </footer>

    </div>
  );
};

export default Main;
