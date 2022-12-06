import styles from './SearchDropdown.module.scss';

const SearchDropdown = (props) => {
    return (
        <div className={styles.dropdown}>
            <div className={styles.dropdownContent}>
                {props.children}
            </div>
        </div>
    );
}

export default SearchDropdown;