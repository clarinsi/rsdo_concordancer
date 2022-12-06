import { useTranslation } from 'react-i18next';

import IndexLayout from '../../layout/IndexLayout';
import ListHelp from '../../components/list/ListHelp';

const ListIndex = () => {
    // Hooks
    const { t } = useTranslation();

    return (
        <IndexLayout source='list' title={t('list.title')} help={<ListHelp />} />
    );
};

export default ListIndex;