import { useTranslation } from 'react-i18next';
import { useQuery } from 'react-query';
import useSearch from '../../hooks/use-search';
import styles from './IndexStatistics.module.scss';

const IndexStatistics = () => {
    const { t } = useTranslation();

    const search = useSearch();
    const corpusId = search.corpusId;

    const fetchStatistics = () => fetch(`${window.baseAppPath}/concordancer/corpus/${corpusId}/stats`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    }).then((res) => {
        return res.json();
    });

    const { isLoading, isSuccess, isError, data, error } = useQuery(['statistics', corpusId], fetchStatistics, { keepPreviousData: true, refetchOnWindowFocus: false });    

    return (
        <div className={styles.stats}>
            <div className='row'>
                <div className={`col-md-4 ${styles.counter}`}><h2>{(!isLoading && isSuccess) ? data.texts : "..."}</h2><p>{t('shared.countTexts')}</p></div>
                <div className={`col-md-4 ${styles.counter}`}><h2>{(!isLoading && isSuccess) ? data.sentences : "..."}</h2><p>{t('shared.countSentences')}</p></div>
                <div className={`col-md-4 ${styles.counter}`}><h2>{(!isLoading && isSuccess) ? data.words : "..."}</h2><p>{t('shared.countWords')}</p></div>
            </div>
        </div>
    );
};

export default IndexStatistics;