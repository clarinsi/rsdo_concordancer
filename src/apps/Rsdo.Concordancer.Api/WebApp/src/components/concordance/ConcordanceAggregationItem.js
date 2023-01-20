import { Link } from 'react-router-dom';
import useSearch from '../../hooks/use-search';
import styles from './ConcordanceAggregationItem.module.scss';

const ConcordanceAggregationItem = (props) => {
    const search = useSearch();
    const isSelected = search.isFiltered('TextIds', props.filterKey) === true;
    const link = isSelected ? search.getClearFilterLink('TextIds', props.filterKey) : search.getFilterLink('TextIds', props.filterKey);

    return (
        <li className={styles.aggregationItem}><Link to={link}>{isSelected && <span className={styles.remove} >X</span>}<span className={styles.title}>{props.title}</span><span className={styles.count}>{props.count}</span></Link></li>
    );
};

export default ConcordanceAggregationItem;