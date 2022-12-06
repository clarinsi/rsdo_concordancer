import { useState } from 'react';
import { Link } from 'react-router-dom';
import { useTranslation } from 'react-i18next';

import styles from './IndexLayout.module.scss';
import searchIcon from '../assets/search.svg';
import historyIcon from '../assets/history.svg';
import helpIcon from '../assets/help.svg';
import concordanceActiveIcon from '../assets/concordance-active.svg';
import concordanceInactiveIcon from '../assets/concordance-inactive.svg';
import listActiveIcon from '../assets/list-active.svg';
import listInactiveIcon from '../assets/list-inactive.svg';
import IndexStatistics from '../components/index/IndexStatistics';
import IndexMenu from '../components/index/IndexMenu';
import useSearch from '../hooks/use-search';
import History from '../components/shared/History';

const IndexLayout = (props) => {
    // Hooks
    const { t } = useTranslation();
    const search = useSearch();

    // State
    const [query, setQuery] = useState(search.getQuery());
    const [isHelpVisible, setIsHelpVisible] = useState(false);
    const [isHistoryVisible, setIsHistoryVisible] = useState(false);

    // Props
    const { source, help, title } = props;
    const isConcordance = source === 'concordance';

    const onSubmitHandler = (e) => {
        e.preventDefault();
        if (query) {
            search.newSearch(source, query);
        }
    };

    const onHistoryClickHandler = () => {
        setIsHistoryVisible(isHistoryVisibleOld => !isHistoryVisibleOld);
    }

    const onHelpClickHandler = () => {
        setIsHelpVisible(isHelpVisibleOld => !isHelpVisibleOld);
    }

    return (
        <>
            <IndexMenu />
            <div className={styles.search}>
                <div className='container-xl'>
                    <div className='row'>
                        <div className='col-xs-12 col-xl-6 offset-xl-3'>
                            <h1>{title}</h1>
                            <ul className={styles.areas}>
                                <li className={isConcordance ? styles.active : null}><img src={isConcordance ? concordanceActiveIcon : concordanceInactiveIcon} alt={t('shared.concordance')} /><Link to={`/${search.corpusId}/concordance`}>{t('shared.concordance')}</Link></li>
                                <li className={!isConcordance ? styles.active : null}><img src={!isConcordance ? listActiveIcon : listInactiveIcon} alt={t('shared.list')} /><Link to={`/${search.corpusId}/list`}>{t('shared.list')}</Link></li>
                            </ul>
                            <form onSubmit={onSubmitHandler}>
                                <div className={`${styles.searchInput} ${isHelpVisible || isHistoryVisible ? styles.dropdownActive : null}`}>
                                    <button className={styles.searchButton} type='submit'><img src={searchIcon} alt='Search' /></button>
                                    <input type='text' autoFocus placeholder={t('shared.enterSearch')} onChange={(e) => setQuery(e.target.value)} />
                                    <button className={styles.historyButton} type='button' onClick={onHistoryClickHandler}><img src={historyIcon} alt='History' /></button>
                                    <button className={styles.helpButton} type='button' onClick={onHelpClickHandler}><img src={helpIcon} alt='Help' /></button>
                                </div>
                            </form>
                            {isHistoryVisible && <History source={source} />}
                            {isHelpVisible && help}
                        </div>
                    </div>
                </div>
            </div>
            <div className='container-xl'>
                <IndexStatistics />
            </div>
        </>
    );
};

export default IndexLayout;