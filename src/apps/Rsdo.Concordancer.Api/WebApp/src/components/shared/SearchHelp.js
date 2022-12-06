import { useTranslation } from 'react-i18next';

import SearchDropdown from './../shared/SearchDropdown.js';
import styles from './SearchHelp.module.scss';

const SearchHelp = (props) => {
    // Hooks
    const { t } = useTranslation();

    return (
        <SearchDropdown>
            <div className={styles.help}>
                <h3>{t('shared.searchHelp')}</h3>
                {props.children}
            </div>
        </SearchDropdown>
    )
};

export default SearchHelp;