import { useTranslation } from 'react-i18next';

import sytles from './ConcordanceDetailsText.module.scss';

const ConcordanceDetailsText = (props) => {
    // Hooks
    const { t } = useTranslation();

    return (
        <>
            <div className={sytles.textInfo}>
                <h5>{t('concordance.detailsTextSource')}</h5>
                <p>{props.source}</p>
            </div>
            <div className={sytles.textInfo}>
                <h5>{t('concordance.detailsTextYear')}</h5>
                <p>{props.year}</p>
            </div>
            <div className={sytles.textInfo}>
                <h5>{t('concordance.detailsTextTitle')}</h5>
                <p>{props.title}</p>
            </div>
            <div className={sytles.textInfo}>
                <h5>{t('concordance.detailsTextAuthor')}</h5>
                <p>{props.author}</p>
            </div>
        </>
    );
};

export default ConcordanceDetailsText;