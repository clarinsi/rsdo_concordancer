import ConcordanceDetailsTextInfo from './ConcordanceDetailsTextInfo';

import { useTranslation } from 'react-i18next';

const ConcordanceDetailsText = (props) => {
    // Hooks
    const { t } = useTranslation();

    return (
        <>
            <ConcordanceDetailsTextInfo title={t('concordance.detailsTextSource')} value={props.source} />
            <ConcordanceDetailsTextInfo title={t('concordance.detailsTextYear')} value={props.year} />
            <ConcordanceDetailsTextInfo title={t('concordance.detailsTextTitle')} value={props.title} />
            <ConcordanceDetailsTextInfo title={t('concordance.detailsTextAuthor')} value={props.author} />
        </>
    );
};

export default ConcordanceDetailsText;