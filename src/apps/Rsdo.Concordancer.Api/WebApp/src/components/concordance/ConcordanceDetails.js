import { useState } from 'react';
import { useQuery } from 'react-query';
import { useTranslation } from 'react-i18next';
import useSearch from '../../hooks/use-search';

import Spinner from '../shared/Spinner';
import ConcordanceDetailsParagraph from './ConcordanceDetailsParagraph';
import ConcordanceDetailsText from './ConcordanceDetailsText';
import ConcordanceDetailsTokens from './ConcordanceDetailsTokens';

import closeIcon from '../../assets/close.svg';
import styles from './ConcordanceDetails.module.scss';


const ConcordanceDetails = (props) => {
    const [activeTab, setActiveTab] = useState(0);

    // Hooks
    const { t } = useTranslation();
    const search = useSearch();
    const body = search.getDetailsRequest(props.paragraphId, props.tokenOrder);

    const fetchDetails = () => fetch(`${window.baseAppPath}/concordancer/corpus/${search.corpusId}/concordances/details`, {
        method: 'POST',
        body: JSON.stringify(body),
        headers: {
            'Content-Type': 'application/json'
        }
    }).then((res) => res.json());

    const { isLoading, isError, data, error } = useQuery(['details', body], fetchDetails, { refetchOnWindowFocus: false });

    const selectParagraphTab = (e) => {
        e.preventDefault();
        setActiveTab(0);
    };

    const selectTokensTab = (e) => {
        e.preventDefault();
        setActiveTab(1);
    }

    if (!isLoading && data) {
        return (
            <div className={styles.details}>
                <div className={styles.tabs}>
                    <ul>
                        <li className={activeTab === 0 ? styles.active : null}><button type='button' className='btn btn-link' onClick={selectParagraphTab}>{t('concordance.detailsParagraph')}</button></li>
                        <li className={activeTab === 1 ? styles.active : null}><button type='button' className='btn btn-link' onClick={selectTokensTab} >{t('concordance.detailsAnnotation')}</button></li>
                    </ul>
                    <button type='button' className={`btn btn-link ${styles.close}`} onClick={props.onClose}><img src={closeIcon} alt='Close' /></button>
                </div>
                <div className='row'>
                    <div className={`col-lg-9 ${styles.mainContent}`}>
                        {activeTab === 0 && <ConcordanceDetailsParagraph tokens={data.tokens} />}
                        {activeTab === 1 && <ConcordanceDetailsTokens tokens={data.tokens} />}
                    </div>
                    <div className={`col-lg-3 ${styles.textInfo}`}>
                        <ConcordanceDetailsText source={data.sourceFile} year={data.year} title={data.title} author={data.author} />
                    </div>
                </div>
            </div>
        );
    } else {
        let content = <></>;
        if (isLoading) {
            content = <Spinner></Spinner>
        } else if (isError) {
            content = <p>{t('shared.searchError')}</p>
        } else if (!isLoading && data && data.items.length === 0) {
            content = <p>{t('shared.noResults')}</p>
        }

        return (
            <div className={styles.details}>
                {content}
            </div>
        );
    }
};

export default ConcordanceDetails;