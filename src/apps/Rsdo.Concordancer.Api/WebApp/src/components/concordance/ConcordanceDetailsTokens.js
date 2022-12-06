import { useTranslation } from 'react-i18next';
import ConcordanceDetailsTokensItem from "./ConcordanceDetailsTokensItem";
import styles from './ConcordanceDetailsTokens.module.scss';

const ConcordanceDetailsTokens = (props) => {
    // Hooks
    const { t } = useTranslation();

    return (
        <>
            <div className={`row ${styles.header}`}>
                <div className='col-lg-4'>{t('concordance.detailsAnnotationWord')}</div>
                <div className='col-lg-4'>{t('concordance.detailsAnnotationBasicForm')}</div>
                <div className='col-lg-4'>{t('concordance.detailsAnnotationPos')}</div>
            </div>
            {props.tokens.filter(x => x.type === 'Word').map((x, i) => <ConcordanceDetailsTokensItem key={i} token={x} />)}
        </>
    );
};

export default ConcordanceDetailsTokens;