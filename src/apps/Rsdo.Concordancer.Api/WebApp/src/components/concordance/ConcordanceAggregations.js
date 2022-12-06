import { useTranslation } from 'react-i18next';

import ConcordanceAlternateSearch from './ConcordanceAlternateSearch';
import ConcordanceAggregation from './ConcordanceAggregation';
import styles from './ConcordanceAggregations.module.scss';

const ConcordanceAggregations = (props) => {
    // Hooks
    const { t } = useTranslation();

    return (
        <div className={styles.aggregations}>
            <ConcordanceAlternateSearch title={t(`concordance.aggregation${props.lemmasAlternateSearch.type}`)} items={props.lemmasAlternateSearch.items} />
            {props.aggregations.map(x => <ConcordanceAggregation key={x.type} title={t(`concordance.aggregation${x.type}`)} items={x.items} />)}
        </div>
    );
};

export default ConcordanceAggregations;