import { useTranslation } from 'react-i18next';

import IndexLayout from '../../layout/IndexLayout';
import ConcordanceHelp from '../../components/concordance/ConcordanceHelp';

const ConcordanceIndex = () => {
    // Hooks
    const { t } = useTranslation();

    return (
        <IndexLayout source='concordance' title={t('concordance.title')} help={<ConcordanceHelp />} />
    );
}

export default ConcordanceIndex;